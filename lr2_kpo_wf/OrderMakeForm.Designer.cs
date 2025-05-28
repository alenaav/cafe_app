namespace lr2_kpo_wf
{
    partial class OrderMakeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TreeView treeViewMenu;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox comboBoxCafes;
        private System.Windows.Forms.Button btnConfirmOrder;

        // Новые элементы:
        private System.Windows.Forms.Label lblAvailablePoints;
        private System.Windows.Forms.TextBox txtPointsToUse;
        private System.Windows.Forms.Label lblFinalTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            treeViewMenu = new TreeView();
            numericQuantity = new NumericUpDown();
            btnAddToOrder = new Button();
            dgvOrder = new DataGridView();
            lblTotal = new Label();
            comboBoxCafes = new ComboBox();
            btnConfirmOrder = new Button();
            lblAvailablePoints = new Label();
            txtPointsToUse = new TextBox();
            lblFinalTotal = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // treeViewMenu
            // 
            treeViewMenu.Location = new Point(12, 12);
            treeViewMenu.Name = "treeViewMenu";
            treeViewMenu.Size = new Size(250, 300);
            treeViewMenu.TabIndex = 0;
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(280, 12);
            numericQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(120, 27);
            numericQuantity.TabIndex = 1;
            numericQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Location = new Point(280, 50);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(150, 30);
            btnAddToOrder.TabIndex = 2;
            btnAddToOrder.Text = "Добавить в заказ";
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.ColumnHeadersHeight = 29;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvOrder.Location = new Point(12, 320);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(600, 200);
            dgvOrder.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(12, 530);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(300, 30);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Итого: 0";
            // 
            // comboBoxCafes
            // 
            comboBoxCafes.Location = new Point(320, 530);
            comboBoxCafes.Name = "comboBoxCafes";
            comboBoxCafes.Size = new Size(200, 28);
            comboBoxCafes.TabIndex = 5;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Location = new Point(530, 530);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(100, 30);
            btnConfirmOrder.TabIndex = 6;
            btnConfirmOrder.Text = "Оформить";
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // lblAvailablePoints
            // 
            lblAvailablePoints.Font = new Font("Segoe UI", 10F);
            lblAvailablePoints.Location = new Point(12, 560);
            lblAvailablePoints.Name = "lblAvailablePoints";
            lblAvailablePoints.Size = new Size(250, 25);
            lblAvailablePoints.TabIndex = 7;
            lblAvailablePoints.Text = "Доступно баллов: 0";
            // 
            // txtPointsToUse
            // 
            txtPointsToUse.Location = new Point(280, 562);
            txtPointsToUse.Name = "txtPointsToUse";
            txtPointsToUse.Size = new Size(100, 27);
            txtPointsToUse.TabIndex = 2;
            txtPointsToUse.TextChanged += txtPointsToUse_TextChanged;
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.Font = new Font("Segoe UI", 10F);
            lblFinalTotal.Location = new Point(400, 562);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(250, 25);
            lblFinalTotal.TabIndex = 8;
            lblFinalTotal.Text = "Итого с учетом баллов: 0";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Продукт";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Количество";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Цена за ед.";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Сумма";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // OrderMakeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 600);
            Controls.Add(treeViewMenu);
            Controls.Add(numericQuantity);
            Controls.Add(btnAddToOrder);
            Controls.Add(dgvOrder);
            Controls.Add(lblTotal);
            Controls.Add(comboBoxCafes);
            Controls.Add(btnConfirmOrder);
            Controls.Add(lblAvailablePoints);
            Controls.Add(txtPointsToUse);
            Controls.Add(lblFinalTotal);
            Name = "OrderMakeForm";
            Text = "Оформление заказа";
            Load += OrderMakeForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
