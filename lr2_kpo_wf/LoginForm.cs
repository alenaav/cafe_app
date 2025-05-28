using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using lr2_kpo_wf.Model;

namespace lr2_kpo_wf
{
    public partial class LoginForm : Form
    {
        private bool registrationMode = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        public string UserName => txtEmail.Text;
        public string Password => txtPassword.Text;
        public string FullName => txtFullName.Text;
        public string Phone => txtPhone.Text;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!registrationMode)
            {
                // Переключаем форму в режим регистрации
                labelFullName.Visible = txtFullName.Visible = true;
                labelPhone.Visible = txtPhone.Visible = true;
                registrationMode = true;
                btnLogin.Enabled = false;
                return;
            }

            // Валидация всех полей
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (txtPassword.Text.Length < 4 || txtPassword.Text.Length > 100)
            {
                MessageBox.Show("Пароль должен быть от 4 до 100 символов");
                return;
            }

            using (var db = new UserContext())
            {
                if (db.Users.Any(u => u.Email == txtEmail.Text))
                {
                    MessageBox.Show("Пользователь с таким email уже существует");
                    return;
                }

                // 1. Создание пользователя
                var newUser = new User
                {
                    Email = txtEmail.Text,
                    PasswordHash = User.ComputeHash(txtPassword.Text), // Метод уже есть
                    FullName = txtFullName.Text,
                    Phone = txtPhone.Text,
                    CreatedAt = DateTime.Now
                };

                db.Users.Add(newUser);
                db.SaveChanges(); // Сохраняем, чтобы получить Id

                // 2. Создание карты
                var newCard = new LoyaltyCard
                {
                    UserId = newUser.Id,
                    CardNumber = GenerateCardNumber(db),
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    Level = "Бронзовый" // Начальный уровень
                };

                db.LoyaltyCards.Add(newCard);
                db.SaveChanges(); // Чтобы получить CardId

                // 3. Создание баллов
                var points = new LoyaltyPoint
                {
                    CardId = newCard.Id,
                    CurrentBalance = 0
                };

                db.LoyaltyPoints.Add(points);
                db.SaveChanges();

                MessageBox.Show("Регистрация прошла успешно! Карта создана.");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Генерация уникального 6-значного номера карты
        /// </summary>
        private string GenerateCardNumber(UserContext db)
        {
            var random = new Random();
            string number;

            do
            {
                number = random.Next(100000, 999999).ToString();
            } while (db.LoyaltyCards.Any(c => c.CardNumber == number));

            return number;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // по умолчанию поля регистрации скрыты
            labelFullName.Visible = false;
            txtFullName.Visible = false;
            labelPhone.Visible = false;
            txtPhone.Visible = false;
        }
    }
}
