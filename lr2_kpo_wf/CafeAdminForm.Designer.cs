namespace lr2_kpo_wf
{
    partial class CafeAdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TreeView treeViewCafes;
        private System.Windows.Forms.Button btnAddCafe;

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
            this.treeViewCafes = new System.Windows.Forms.TreeView();
            this.btnAddCafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewCafes
            // 
            this.treeViewCafes.Location = new System.Drawing.Point(12, 12);
            this.treeViewCafes.Name = "treeViewCafes";
            this.treeViewCafes.Size = new System.Drawing.Size(460, 300);
            this.treeViewCafes.TabIndex = 0;
            this.treeViewCafes.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewCafes_NodeMouseClick);
            // 
            // btnAddCafe
            // 
            this.btnAddCafe.Location = new System.Drawing.Point(12, 320);
            this.btnAddCafe.Name = "btnAddCafe";
            this.btnAddCafe.Size = new System.Drawing.Size(460, 35);
            this.btnAddCafe.TabIndex = 1;
            this.btnAddCafe.Text = "Добавить кафе";
            this.btnAddCafe.UseVisualStyleBackColor = true;
            this.btnAddCafe.Click += new System.EventHandler(this.btnAddCafe_Click);
            // 
            // CafeAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 371);
            this.Controls.Add(this.btnAddCafe);
            this.Controls.Add(this.treeViewCafes);
            this.Name = "CafeAdminForm";
            this.Text = "Управление кафе";
            this.ResumeLayout(false);
        }
    }
}
