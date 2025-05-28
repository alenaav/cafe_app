using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore; // добавьте если отсутствует
using System;
using System.Linq;
using System.Windows.Forms;
using lr2_kpo_wf.Model;

namespace lr2_kpo_wf
{
    public partial class OrdersHistoryForm : Form
    {
        private readonly User currentUser;

        public OrdersHistoryForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadOrderHistory();
        }

        private void LoadOrderHistory()
        {
            treeViewOrders.Nodes.Clear();

            using (var db = new UserContext())
            {
                // Подгружаем все заказы пользователя с нужными связями вручную
                var orders = (from o in db.Orders
                              where o.UserId == currentUser.Id
                              join c in db.Cafes on o.CafeId equals c.Id
                              join oi in db.OrderItems on o.Id equals oi.OrderId
                              join p in db.Products on oi.ProductId equals p.Id
                              group new { o, c, oi, p } by new { o.Id, o.OrderDate, o.TotalAmount, c.Name } into orderGroup
                              select new
                              {
                                  OrderId = orderGroup.Key.Id,
                                  OrderDate = orderGroup.Key.OrderDate,
                                  CafeName = orderGroup.Key.Name,
                                  TotalAmount = orderGroup.Key.TotalAmount,
                                  Items = orderGroup.Select(g => new
                                  {
                                      ProductName = g.p.Name,
                                      g.oi.Quantity
                                  }).ToList()
                              }).OrderByDescending(o => o.OrderDate).ToList();

                foreach (var order in orders)
                {
                    var orderNode = new TreeNode(order.OrderDate.ToString("dd.MM.yyyy HH:mm:ss"));
                    var cafeNode = new TreeNode($"Кафе: {order.CafeName}");
                    orderNode.Nodes.Add(cafeNode);

                    var totalNode = new TreeNode($"Сумма заказа: {order.TotalAmount} руб.");
                    cafeNode.Nodes.Add(totalNode);

                    foreach (var item in order.Items)
                    {
                        var productNode = new TreeNode(item.ProductName);
                        var quantityNode = new TreeNode($"Количество: {item.Quantity}");
                        productNode.Nodes.Add(quantityNode);

                        totalNode.Nodes.Add(productNode);
                    }

                    treeViewOrders.Nodes.Add(orderNode);
                }
            }

            treeViewOrders.ExpandAll();
        }



        private void OrdersHistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}