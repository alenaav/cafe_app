namespace lr2_kpo_wf
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblPhone;
        private Label lblName;
        private Label lblEmail;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtEmail;
        private Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblPhone = new Label();
            lblName = new Label();
            lblEmail = new Label();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 25);
            lblTitle.Text = "Профиль";

            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 70);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(55, 15);
            lblPhone.Text = "Телефон:";

            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 67);
            txtPhone.Size = new Size(200, 23);

            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 110);
            lblName.Text = "ФИО:";

            // 
            // txtName
            // 
            txtName.Location = new Point(120, 107);
            txtName.Size = new Size(200, 23);

            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 150);
            lblEmail.Text = "Email:";

            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 147);
            txtEmail.Size = new Size(200, 23);

            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 190);
            btnSave.Size = new Size(100, 30);
            btnSave.Text = "Сохранить";
            btnSave.Click += btnSave_Click;

            // 
            // ProfileForm
            // 
            ClientSize = new Size(360, 250);
            Controls.Add(lblTitle);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "ProfileForm";
            Text = "Профиль пользователя";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
