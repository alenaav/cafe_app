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
                    // ������� ����� �� email � ������
                    currentUser = User.Login(loginForm.UserName, loginForm.Password);
                    if (currentUser.Email == "cafe@mail.ru")
                    {
                        Application.Run(new AdminForm());
                        return;
                    }
                    if (currentUser != null)
                    {
                        // �������� ����
                        Application.Run(new UserForm(currentUser));
                        return;
                    }
                    else
                    {
                        MessageBox.Show("�������� email ��� ������", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}