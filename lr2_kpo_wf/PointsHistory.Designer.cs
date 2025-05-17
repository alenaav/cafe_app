using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lr2_kpo_wf
{
    partial class PointsHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvPointsHistory;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPointsHistory = new DataGridView();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // dgvPointsHistory
            // 
            dgvPointsHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPointsHistory.Location = new Point(20, 60);
            dgvPointsHistory.Name = "dgvPointsHistory";
            dgvPointsHistory.RowHeadersWidth = 51;
            dgvPointsHistory.RowTemplate.Height = 29;
            dgvPointsHistory.Size = new Size(540, 300);
            dgvPointsHistory.ReadOnly = true;
            dgvPointsHistory.AllowUserToAddRows = false;
            dgvPointsHistory.AllowUserToDeleteRows = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 25);
            lblTitle.Text = "История баллов пользователя";
            // 
            // PointsHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 380);
            Controls.Add(dgvPointsHistory);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PointsHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "История баллов";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}