namespace lr2_kpo_wf
{
    partial class AddOrEditCafeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;

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
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            btnSave = new Button();
            lblName = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(143, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(334, 27);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(143, 121);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(334, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(143, 179);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(334, 27);
            txtPhone.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(143, 259);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 52);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить новое кафе";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.Location = new Point(54, 69);
            lblName.Name = "lblName";
            lblName.Size = new Size(81, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Название:";
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(76, 125);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(61, 23);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Адрес:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(56, 183);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(81, 23);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Телефон:";
            // 
            // AddOrEditCafeForm
            // 
            ClientSize = new Size(547, 356);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(btnSave);
            Name = "AddOrEditCafeForm";
            Text = "Добавление/редактирование кафе";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
