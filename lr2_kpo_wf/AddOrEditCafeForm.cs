using System;
using System.Windows.Forms;
using System.Xml.Linq;
using lr2_kpo_wf.Model;

namespace lr2_kpo_wf
{
    public partial class AddOrEditCafeForm : Form
    {
        private Cafe editingCafe;

        public AddOrEditCafeForm(Cafe cafe = null)
        {
            InitializeComponent();
            editingCafe = cafe;

            if (editingCafe != null)
            {
                txtName.Text = editingCafe.Name;
                txtAddress.Text = editingCafe.Address;
                txtPhone.Text = editingCafe.Phone;
                this.Text = "Редактировать кафе";
                btnSave.Text = "Сохранить изменения";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new UserContext())
            {
                if (editingCafe == null)
                {
                    var newCafe = new Cafe
                    {
                        Name = txtName.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        Phone = txtPhone.Text.Trim()
                    };
                    db.Cafes.Add(newCafe);
                }
                else
                {
                    var cafe = db.Cafes.Find(editingCafe.Id);
                    cafe.Name = txtName.Text.Trim();
                    cafe.Address = txtAddress.Text.Trim();
                    cafe.Phone = txtPhone.Text.Trim();
                }

                db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
