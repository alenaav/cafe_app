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
    public partial class PointsHistoryForm : Form
    {
        private readonly User currentUser;

        public PointsHistoryForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadPointsHistory();
        }

        private void LoadPointsHistory()
        {
            using (var db = new UserContext())
            {
                var card = db.LoyaltyCards.FirstOrDefault(c => c.UserId == currentUser.Id);

                if (card == null)
                {
                    MessageBox.Show("Карта лояльности не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var history = db.PointsHistories
                                .Where(h => h.CardId == card.Id)
                                .OrderByDescending(h => h.ChangeDate)
                                .Select(h => new
                                {
                                    Баллы = h.PointsChange,
                                    Дата = h.ChangeDate
                                })
                                .ToList();

                dgvPointsHistory.DataSource = history;

                // Дополнительно — чтобы заголовки в DataGridView гарантированно были на русском
                dgvPointsHistory.Columns[0].HeaderText = "Изменение баллов";
                dgvPointsHistory.Columns[1].HeaderText = "Дата изменения";

                // Если авторазмер колонок нужен
                dgvPointsHistory.AutoResizeColumns();
            }
        }

        private void PointsHistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
