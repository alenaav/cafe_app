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
    public partial class CardNumberPromptForm : Form
    {
        public string CardNumber { get; private set; }

        public CardNumberPromptForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var input = txtCardNumber.Text.Trim();

            using (var db = new UserContext())
            {
                var card = db.LoyaltyCards.FirstOrDefault(c => c.CardNumber == input);
                if (card == null)
                {
                    MessageBox.Show("Карта не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CardNumber = input;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }

}
