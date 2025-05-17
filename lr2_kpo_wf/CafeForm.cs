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

using System;
using System.Linq;
using System.Windows.Forms;
using lr2_kpo_wf.Model;

namespace lr2_kpo_wf
{
    public partial class CafeForm : Form
    {
        public CafeForm()
        {
            InitializeComponent();
            LoadCafes();
        }

        private void LoadCafes()
        {
            using (var db = new UserContext())
            {
                var cafes = db.Cafes
                              .Select(c => new
                              {
                                  Название = c.Name,
                                  Адрес = c.Address,
                                  Телефон = c.Phone
                              })
                              .ToList();

                dgvCafes.DataSource = cafes;
            }
        }
    }
}

