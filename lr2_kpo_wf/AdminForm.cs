using System;
using System.Linq;
using System.Windows.Forms;
using lr2_kpo_wf.Model;

namespace lr2_kpo_wf
{
    public partial class AdminForm : Form
    {
        private class UserWithCard
        {
            public int Id { get; set; }
            public string Имя { get; set; }
            public string Почта { get; set; }
            public string Пароль { get; set; }
            public string Телефон { get; set; }
            public string НомерКарты { get; set; }
            public bool АктивнаЛиКарта { get; set; }
            public int БонусныеБаллы { get; set; }
        }

        public AdminForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var db = new UserContext())
            {
                var usersWithCards = (from u in db.Users
                                      join c in db.Set<LoyaltyCard>() on u.Id equals c.UserId into cardGroup
                                      from c in cardGroup.DefaultIfEmpty()
                                      join p in db.Set<LoyaltyPoint>() on c.Id equals p.CardId into pointsGroup
                                      from p in pointsGroup.DefaultIfEmpty()
                                      select new UserWithCard
                                      {
                                          Id = u.Id,
                                          Имя = u.FullName,
                                          Почта = u.Email,
                                          Пароль = u.PasswordHash,
                                          Телефон = u.Phone,
                                          НомерКарты = c != null ? c.CardNumber : "",
                                          АктивнаЛиКарта = c != null && c.IsActive,
                                          БонусныеБаллы = p != null ? p.CurrentBalance : 0
                                      }).ToList();

                dgvUsers.DataSource = new BindingSource { DataSource = usersWithCards };
            }

            dgvUsers.Columns["НомерКарты"].ReadOnly = true;
            dgvUsers.Columns["БонусныеБаллы"].ReadOnly = true;
            dgvUsers.Columns["Id"].Visible = false;
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
                    if (user == null) continue;

                    user.FullName = row.Cells["Имя"].Value?.ToString();
                    user.Email = row.Cells["Почта"].Value?.ToString();
                    user.PasswordHash = row.Cells["Пароль"].Value?.ToString();
                    user.Phone = row.Cells["Телефон"].Value?.ToString();

                    var card = db.Set<LoyaltyCard>().FirstOrDefault(c => c.UserId == userId);
                    if (card != null)
                    {
                        bool newStatus = Convert.ToBoolean(row.Cells["АктивнаЛиКарта"].Value);
                        card.IsActive = newStatus;
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

        private void btnManageCafes_Click(object sender, EventArgs e)
        {
            var cafeForm = new CafeAdminForm();
            cafeForm.ShowDialog();
        }
    }
}
