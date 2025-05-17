using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using (var db = new UserContext())
            {
                var orders = from o in db.Orders
                             where o.UserId == currentUser.Id
                             join item in db.OrderItems on o.Id equals item.OrderId
                             join product in db.Products on item.ProductId equals product.Id
                             join category in db.ProductCategories on product.CategoryId equals category.Id
                             select new
                             {
                                 OrderId = o.Id,
                                 OrderDate = o.OrderDate,
                                 ProductName = product.Name,
                                 Category = category.Name,
                                 Quantity = item.Quantity,
                                 PriceAtOrder = item.PriceAtOrder,
                                 Total = item.Quantity * item.PriceAtOrder
                             };

                dgvOrders.DataSource = orders.ToList();
            }
        }
    }
}