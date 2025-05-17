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
    public partial class UserForm : Form
    {
        private readonly User currentUser;

        public UserForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadLoyaltyCard();
        }

        private void LoadLoyaltyCard()
        {
            using (var db = new UserContext())
            {
                var card = db.LoyaltyCards
                             .FirstOrDefault(c => c.UserId == currentUser.Id);

                if (card != null)
                {
                    txtCardNumber.Text = card.CardNumber;
                    txtIsActive.Text = card.IsActive ? "Да" : "Нет";
                    txtCreatedAt.Text = card.CreatedAt.ToString("g");

                    var points = db.LoyaltyPoints
                                   .FirstOrDefault(p => p.CardId == card.Id);

                    if (points != null)
                    {
                        txtCurrentBalance.Text = points.CurrentBalance.ToString();
                    }
                    else
                    {
                        txtCurrentBalance.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("У вас пока нет карты лояльности.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void историяКартыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyForm = new PointsHistoryForm(currentUser); // currentUser — переданный в UserForm пользователь
            historyForm.ShowDialog();
        }

        private void историяЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ordersForm = new OrdersHistoryForm(currentUser); // currentUser — переданный в UserForm пользователь
            ordersForm.ShowDialog();
        }

        private void списокКафеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cafeForm = new CafeForm();
            cafeForm.ShowDialog();
        }

        private void профильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var profileForm = new ProfileForm(currentUser);
            profileForm.ShowDialog();
        }
    }
}
