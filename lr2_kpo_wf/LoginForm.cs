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

                var newUser = new User
                {
                    Email = txtEmail.Text,
                    PasswordHash = User.ComputeHash(txtPassword.Text),
                    FullName = txtFullName.Text,
                    Phone = txtPhone.Text,
                    CreatedAt = DateTime.Now
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Регистрация прошла успешно!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
