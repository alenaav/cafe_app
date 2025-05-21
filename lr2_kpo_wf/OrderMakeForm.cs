using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // Загрузить категории и продукты
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

            // Загрузить кафе
            comboBoxCafes.DataSource = db.Cafes.ToList();
            comboBoxCafes.DisplayMember = "Name";
            comboBoxCafes.ValueMember = "Id";
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
            lblTotal.Text = $"Итого: {totalAmount:C}";

            dgvOrder.Rows.Add(product.Name, quantity, product.CurrentPrice, quantity * product.CurrentPrice);
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            var cafeId = (int)comboBoxCafes.SelectedValue;

            using var db = new UserContext();
            using var transaction = db.Database.BeginTransaction();

            try
            {
                // Создать заказ
                var order = new Order
                {
                    UserId = user.Id,
                    CafeId = cafeId,
                    OrderDate = DateTime.Now,
                    TotalAmount = (double)totalAmount
                };

                db.Orders.Add(order);
                db.SaveChanges();

                // Добавить товары
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

                db.SaveChanges();

                // Начислить баллы (10%)
                int points = (int)(totalAmount * 0.10m);
                var loyaltyPoints = db.LoyaltyPoints.FirstOrDefault(p => p.CardId == card.Id);
                if (loyaltyPoints != null)
                {
                    loyaltyPoints.CurrentBalance += points;
                    loyaltyPoints.LastUpdate = DateTime.Now;
                }
                else
                {
                    db.LoyaltyPoints.Add(new LoyaltyPoint
                    {
                        CardId = card.Id,
                        CurrentBalance = points,
                        LastUpdate = DateTime.Now
                    });
                }

                // История баллов
                db.PointsHistories.Add(new PointsHistory
                {
                    CardId = card.Id,
                    PointsChange = points,
                    OrderId = order.Id,
                    ChangeDate = DateTime.Now
                });

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
    }

}
