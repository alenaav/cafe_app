namespace lr2_kpo_wf
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private Label labelEmail;
        private Label labelPassword;
        private Label labelFullName;
        private Label labelPhone;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private Button btnLogin;
        private Button btnRegister;

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
            labelTitle = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            labelFullName = new Label();
            labelPhone = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(174, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(135, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Войдите в аккаунт";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 48);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 27);
            txtEmail.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(12, 84);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(62, 20);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(92, 81);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(338, 27);
            txtPassword.TabIndex = 4;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(12, 120);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(83, 20);
            labelFullName.TabIndex = 5;
            labelFullName.Text = "Полное имя";
            labelFullName.Visible = false;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(101, 117);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(329, 27);
            txtFullName.TabIndex = 6;
            txtFullName.Visible = false;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(12, 156);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 20);
            labelPhone.TabIndex = 7;
            labelPhone.Text = "Телефон";
            labelPhone.Visible = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(92, 153);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(338, 27);
            txtPhone.TabIndex = 8;
            txtPhone.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(174, 190);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(135, 51);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(186, 254);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 29);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 300);
            Controls.Add(labelTitle);
            Controls.Add(labelEmail);
            Controls.Add(txtEmail);
            Controls.Add(labelPassword);
            Controls.Add(txtPassword);
            Controls.Add(labelFullName);
            Controls.Add(txtFullName);
            Controls.Add(labelPhone);
            Controls.Add(txtPhone);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}