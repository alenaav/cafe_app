using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using lr2_kpo_wf.Model;
using Microsoft.EntityFrameworkCore;

namespace lr2_kpo_wf
{
    public partial class OrderMakeForm : Form
    {
        private readonly string cardNumber;
        private LoyaltyCard card;
        private User user;
        private decimal totalAmount = 0;
        private int availablePoints = 0;
        private int usedPoints = 0;
        private List<(Product product, int quantity)> orderItems = new();

        public OrderMakeForm(string cardNumber)
        {
            InitializeComponent();
            this.cardNumber = cardNumber;
            LoadData();
        }

        private void LoadData()
        {
            using var db = new UserContext();

            card = db.LoyaltyCards.First(c => c.CardNumber == cardNumber);
            user = db.Users.First(u => u.Id == card.UserId);

            var categories = db.ProductCategories.Include(c => c.Products).ToList();
            foreach (var category in categories)
            {
                var node = new TreeNode(category.Name) { Tag = category };
                foreach (var product in db.Products.Where(p => p.CategoryId == category.Id))
                {
                    var child = new TreeNode($"{product.Name} - {product.CurrentPrice:C}") { Tag = product };
                    node.Nodes.Add(child);
                }
                treeViewMenu.Nodes.Add(node);
            }

            comboBoxCafes.DataSource = db.Cafes.ToList();
            comboBoxCafes.DisplayMember = "Name";
            comboBoxCafes.ValueMember = "Id";

            var dbPoints = db.LoyaltyPoints.FirstOrDefault(p => p.CardId == card.Id);
            availablePoints = dbPoints?.CurrentBalance ?? 0;
            lblAvailablePoints.Text = $"Доступно баллов: {availablePoints}";
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (treeViewMenu.SelectedNode?.Tag is not Product product)
            {
                MessageBox.Show("Выберите продукт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity = (int)numericQuantity.Value;
            if (quantity <= 0) return;

            orderItems.Add((product, quantity));
            totalAmount += (decimal)product.CurrentPrice * quantity;

            dgvOrder.Rows.Add(product.Name, quantity, product.CurrentPrice, quantity * product.CurrentPrice);

            lblTotal.Text = $"Итого: {totalAmount:C}";
            UpdateFinalTotal();
        }

        private void txtPointsToUse_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPointsToUse.Text, out usedPoints))
                usedPoints = 0;

            usedPoints = Math.Min(usedPoints, availablePoints);
            UpdateFinalTotal();
        }

        private void UpdateFinalTotal()
        {
            decimal finalAmount = totalAmount - usedPoints;
            if (finalAmount < 0) finalAmount = 0;
            lblFinalTotal.Text = $"Итого с учетом баллов: {finalAmount:C}";
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            var cafeId = (int)comboBoxCafes.SelectedValue;

            using var db = new UserContext();
            using var transaction = db.Database.BeginTransaction();

            try
            {
                var order = new Order
                {
                    UserId = user.Id,
                    CafeId = cafeId,
                    OrderDate = DateTime.Now,
                    TotalAmount = (double)totalAmount
                };

                db.Orders.Add(order);
                db.SaveChanges();

                foreach (var (product, quantity) in orderItems)
                {
                    db.OrderItems.Add(new OrderItem
                    {
                        OrderId = order.Id,
                        ProductId = product.Id,
                        Quantity = quantity,
                        PriceAtOrder = product.CurrentPrice
                    });
                }

                // Списываем баллы
                if (usedPoints > 0)
                {
                    var lp = db.LoyaltyPoints.FirstOrDefault(p => p.CardId == card.Id);
                    if (lp != null)
                    {
                        lp.CurrentBalance -= usedPoints;
                        lp.LastUpdate = DateTime.Now;
                    }

                    db.PointsHistories.Add(new PointsHistory
                    {
                        CardId = card.Id,
                        PointsChange = -usedPoints,
                        OrderId = order.Id,
                        ChangeDate = DateTime.Now
                    });

                    order.TotalAmount -= usedPoints;
                }

                // Начисление новых баллов
                int earnedPoints = (int)((decimal)order.TotalAmount * 0.10m);
                var loyaltyPoints = db.LoyaltyPoints.FirstOrDefault(p => p.CardId == card.Id);
                if (loyaltyPoints != null)
                {
                    loyaltyPoints.CurrentBalance += earnedPoints;
                    loyaltyPoints.LastUpdate = DateTime.Now;
                }
                else
                {
                    db.LoyaltyPoints.Add(new LoyaltyPoint
                    {
                        CardId = card.Id,
                        CurrentBalance = earnedPoints,
                        LastUpdate = DateTime.Now
                    });
                }

                db.PointsHistories.Add(new PointsHistory
                {
                    CardId = card.Id,
                    PointsChange = earnedPoints,
                    OrderId = order.Id,
                    ChangeDate = DateTime.Now
                });

                // Обновить уровень карты
                var totalSpent = db.Orders
                    .Where(o => o.UserId == user.Id)
                    .Sum(o => (decimal)o.TotalAmount);

                if (totalSpent >= 30000 && card.Level != "gold")
                {
                    card.Level = "gold";
                }
                else if (totalSpent >= 10000 && card.Level != "silver" && card.Level != "gold")
                {
                    card.Level = "silver";
                }
                else if (totalSpent < 10000 && card.Level != "bronze")
                {
                    card.Level = "bronze";
                }
                db.SaveChanges();
                transaction.Commit();

                MessageBox.Show("Заказ оформлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrderMakeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
