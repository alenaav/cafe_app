namespace lr2_kpo_wf
{
    partial class OrdersHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private TreeView treeViewOrders;

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
            this.lblTitle = new Label();
            this.treeViewOrders = new TreeView();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(214, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "История заказов";
            // 
            // treeViewOrders
            // 
            this.treeViewOrders.Location = new Point(20, 70);
            this.treeViewOrders.Name = "treeViewOrders";
            this.treeViewOrders.Size = new Size(700, 350);
            this.treeViewOrders.TabIndex = 1;
            this.treeViewOrders.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // OrdersHistoryForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(740, 450);
            this.Controls.Add(this.treeViewOrders);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Name = "OrdersHistoryForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "История заказов";
            this.Load += new EventHandler(this.OrdersHistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
