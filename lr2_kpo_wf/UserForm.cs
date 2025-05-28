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
                    lblCardNumber.Text = $"Номер карты: {card.CardNumber}";
                    lblIsActive.Text = $"Активна: {(card.IsActive ? "Да" : "Нет")}";
                    lblCreatedAt.Text = $"Дата регистрации: {card.CreatedAt.ToString("dd.MM.yyyy")}";
                    lblLevel.Text = $"Уровень: {card.Level}";

                    var points = db.LoyaltyPoints.FirstOrDefault(p => p.CardId == card.Id);

                    if (points != null)
                    {
                        lblCurrentBalance.Text = $"Баланс баллов: {points.CurrentBalance}";
                    }
                    else
                    {
                        lblCurrentBalance.Text = "Баланс баллов: 0";
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

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void lblLevel_Click(object sender, EventArgs e)
        {

        }
    }
}
