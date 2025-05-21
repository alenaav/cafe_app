using System;
using System.Linq;
using System.Windows.Forms;
using lr2_kpo_wf.Model;

namespace lr2_kpo_wf
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var db = new UserContext())
            {
                var users = db.Users.ToList();
                dgvUsers.DataSource = new BindingSource { DataSource = users };
            }

            // Убедимся, что нужные столбцы можно редактировать:
            dgvUsers.Columns["Id"].ReadOnly = true;
            dgvUsers.Columns["CreatedAt"].ReadOnly = true;
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using (var db = new UserContext())
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    if (row.IsNewRow) continue;

                    int userId = Convert.ToInt32(row.Cells["Id"].Value);
                    var user = db.Users.FirstOrDefault(u => u.Id == userId);

                    if (user != null)
                    {
                        user.Email = row.Cells["Email"].Value?.ToString();
                        user.FullName = row.Cells["FullName"].Value?.ToString();
                        user.Phone = row.Cells["Phone"].Value?.ToString();
                        user.PasswordHash = row.Cells["PasswordHash"].Value?.ToString();
                    }
                }

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Изменения сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var addForm = new AddUserForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            var prompt = new CardNumberPromptForm();
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                var form = new OrderMakeForm(prompt.CardNumber);
                form.ShowDialog();
            }
        }
    }
}
