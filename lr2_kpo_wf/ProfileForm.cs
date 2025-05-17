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
using System.Xml.Linq;

namespace lr2_kpo_wf
{
    public partial class ProfileForm : Form
    {
        private readonly User currentUser;

        public ProfileForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadUserData();
        }

        private void LoadUserData()
        {
            txtPhone.Text = currentUser.Phone;
            txtName.Text = currentUser.FullName;
            txtEmail.Text = currentUser.Email;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new UserContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == currentUser.Id);
                if (user == null)
                {
                    MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                user.Phone = txtPhone.Text.Trim();
                user.FullName = txtName.Text.Trim();
                user.Email = txtEmail.Text.Trim();

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentUser.Phone = user.Phone;
                    currentUser.FullName = user.FullName;
                    currentUser.Email = user.Email;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
