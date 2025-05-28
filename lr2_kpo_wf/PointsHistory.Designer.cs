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
            ((System.ComponentModel.ISupportInitialize)dgvPointsHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvPointsHistory
            // 
            dgvPointsHistory.AllowUserToAddRows = false;
            dgvPointsHistory.AllowUserToDeleteRows = false;
            dgvPointsHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPointsHistory.Location = new Point(20, 60);
            dgvPointsHistory.Name = "dgvPointsHistory";
            dgvPointsHistory.ReadOnly = true;
            dgvPointsHistory.RowHeadersWidth = 51;
            dgvPointsHistory.Size = new Size(540, 300);
            dgvPointsHistory.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(377, 32);
            lblTitle.TabIndex = 1;
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
            Load += PointsHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPointsHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}