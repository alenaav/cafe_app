using System;
using System.Windows.Forms;
using lr2_kpo_wf.Model;
using Microsoft.EntityFrameworkCore;

namespace lr2_kpo_wf
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var db = new UserContext())
            {
                Console.WriteLine(db.Database.GetDbConnection().DataSource);
                db.Database.EnsureCreated();
            }

            User currentUser = null;
            using (var loginForm = new LoginForm())
            {
                while (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Попытка входа по email и паролю
                    currentUser = User.Login(loginForm.UserName, loginForm.Password);
                    if (currentUser != null)
                    {
                        // Успешный вход
                        Application.Run(new UserForm(currentUser));
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Неверный email или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}