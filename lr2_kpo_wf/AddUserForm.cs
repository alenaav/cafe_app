using System;
using System.Windows.Forms;
using System.Xml.Linq;
using lr2_kpo_wf.Model;

namespace lr2_kpo_wf
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newUser = new User
            {
                FullName = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                PasswordHash = txtPassword.Text.Trim(),
                CreatedAt = DateTime.Now
            };

            using (var db = new UserContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Users.Add(newUser);
                        db.SaveChanges();

                        // Сгенерировать уникальный 6-значный номер карты
                        string cardNumber;
                        Random rng = new Random();

                        do
                        {
                            cardNumber = rng.Next(100000, 999999).ToString();
                        } while (db.LoyaltyCards.Any(c => c.CardNumber == cardNumber));

                        var loyaltyCard = new LoyaltyCard
                        {
                            UserId = newUser.Id,
                            CardNumber = cardNumber,
                            IsActive = true,
                            CreatedAt = DateTime.Now
                        };

                        db.LoyaltyCards.Add(loyaltyCard);
                        db.SaveChanges();

                        transaction.Commit();

                        MessageBox.Show("Пользователь и карта лояльности добавлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
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

    }
}
