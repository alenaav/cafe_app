using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using lr2_kpo_wf.Model;

namespace lr2_kpo_wf
{
    public partial class CafeAdminForm : Form
    {
        public CafeAdminForm()
        {
            InitializeComponent();
            LoadCafes();
        }

        private void LoadCafes()
        {
            treeViewCafes.Nodes.Clear();

            using (var db = new UserContext())
            {
                var cafes = db.Cafes.ToList();

                foreach (var cafe in cafes)
                {
                    // Корневой узел — имя кафе
                    TreeNode cafeNode = new TreeNode(cafe.Name)
                    {
                        Tag = cafe
                    };

                    // Дочерние узлы — адрес и телефон
                    TreeNode addressNode = new TreeNode($"Адрес: {cafe.Address}");
                    TreeNode phoneNode = new TreeNode($"Телефон: {cafe.Phone}");

                    cafeNode.Nodes.Add(addressNode);
                    cafeNode.Nodes.Add(phoneNode);

                    treeViewCafes.Nodes.Add(cafeNode);
                }
            }

            treeViewCafes.ExpandAll(); // или убрать, если хочешь по умолчанию свернуто
        }


        private void btnAddCafe_Click(object sender, EventArgs e)
        {
            var addForm = new AddOrEditCafeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadCafes();
            }
        }

        private void treeViewCafes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 0 && e.Node.Tag is Cafe selectedCafe)
            {
                var contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add("Изменить кафе", null, (s, ev) => EditCafe(e.Node));
                contextMenu.Items.Add("Удалить кафе", null, (s, ev) => DeleteCafe(e.Node));
                contextMenu.Show(treeViewCafes, e.Location);
            }
        }

        private void EditCafe(TreeNode node)
        {
            var cafe = node.Tag as Cafe;
            var editForm = new AddOrEditCafeForm(cafe);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadCafes();
            }
        }

        private void DeleteCafe(TreeNode node)
        {
            var cafe = node.Tag as Cafe;

            var confirm = MessageBox.Show($"Удалить кафе '{cafe.Name}'?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (var db = new UserContext())
                {
                    db.Cafes.Remove(db.Cafes.Find(cafe.Id));
                    db.SaveChanges();
                }

                LoadCafes();
            }
        }
    }
}
