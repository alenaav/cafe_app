namespace lr2_kpo_wf
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvUsers;
        private Button btnSaveChanges;
        private Button btnAddUser;
        private Label lblTitle;
        private System.Windows.Forms.Button btnManageCafes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvUsers = new DataGridView();
            btnSaveChanges = new Button();
            btnAddUser = new Button();
            lblTitle = new Label();
            btnMakeOrder = new Button();
            btnManageCafes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeight = 29;
            dgvUsers.Location = new Point(20, 60);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(760, 320);
            dgvUsers.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(20, 400);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(120, 30);
            btnSaveChanges.TabIndex = 2;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(146, 401);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(132, 30);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Добавить пользователя";
            btnAddUser.Click += btnAddUser_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(359, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Управление пользователями";
            // 
            // btnMakeOrder
            // 
            btnMakeOrder.Location = new Point(618, 400);
            btnMakeOrder.Name = "btnMakeOrder";
            btnMakeOrder.Size = new Size(162, 29);
            btnMakeOrder.TabIndex = 4;
            btnMakeOrder.Text = "Оформить заказ";
            btnMakeOrder.UseVisualStyleBackColor = true;
            btnMakeOrder.Click += btnMakeOrder_Click;
            // 
            // btnManageCafes
            // 
            btnManageCafes.Location = new Point(450, 400);
            btnManageCafes.Name = "btnManageCafes";
            btnManageCafes.Size = new Size(162, 29);
            btnManageCafes.TabIndex = 5;
            btnManageCafes.Text = "Управление кафе";
            btnManageCafes.UseVisualStyleBackColor = true;
            btnManageCafes.Click += btnManageCafes_Click;
            // 
            // AdminForm
            // 
            ClientSize = new Size(800, 460);
            Controls.Add(btnMakeOrder);
            Controls.Add(lblTitle);
            Controls.Add(dgvUsers);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnAddUser);
            Controls.Add(btnManageCafes);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Админ-панель";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnMakeOrder;
    }
}
