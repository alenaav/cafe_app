namespace lr2_kpo_wf
{
    partial class CafeForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvCafes;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvCafes = new DataGridView();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCafes).BeginInit();
            SuspendLayout();
            // 
            // dgvCafes
            // 
            dgvCafes.AllowUserToAddRows = false;
            dgvCafes.AllowUserToDeleteRows = false;
            dgvCafes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCafes.Location = new Point(20, 60);
            dgvCafes.Name = "dgvCafes";
            dgvCafes.ReadOnly = true;
            dgvCafes.RowHeadersVisible = false;
            dgvCafes.RowHeadersWidth = 51;
            dgvCafes.Size = new Size(760, 350);
            dgvCafes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCafes.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Список всех кафе";
            // 
            // CafeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCafes);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CafeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Кафе";
            Load += CafeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCafes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
