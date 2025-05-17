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
            SuspendLayout();
            // 
            // dgvCafes
            // 
            dgvCafes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCafes.Location = new Point(20, 60);
            dgvCafes.Name = "dgvCafes";
            dgvCafes.ReadOnly = true;
            dgvCafes.Size = new Size(500, 300);
            dgvCafes.AllowUserToAddRows = false;
            dgvCafes.AllowUserToDeleteRows = false;
            dgvCafes.RowHeadersVisible = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 25);
            lblTitle.Text = "Список всех кафе";
            // 
            // CafeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 400);
            Controls.Add(dgvCafes);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CafeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Кафе";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
