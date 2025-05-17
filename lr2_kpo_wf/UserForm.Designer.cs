﻿// UserForm.Designer.cs
namespace lr2_kpo_wf
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblCardNumber;
        private Label lblIsActive;
        private Label lblCreatedAt;
        private Label lblCurrentBalance;
        private TextBox txtCardNumber;
        private TextBox txtIsActive;
        private TextBox txtCreatedAt;
        private TextBox txtCurrentBalance;

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
            lblTitle = new Label();
            lblCardNumber = new Label();
            lblIsActive = new Label();
            lblCreatedAt = new Label();
            lblCurrentBalance = new Label();
            txtCardNumber = new TextBox();
            txtIsActive = new TextBox();
            txtCreatedAt = new TextBox();
            txtCurrentBalance = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(397, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Карта лояльности пользователя";
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Location = new Point(20, 70);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(105, 20);
            lblCardNumber.TabIndex = 1;
            lblCardNumber.Text = "Номер карты:";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(20, 110);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(69, 20);
            lblIsActive.TabIndex = 3;
            lblIsActive.Text = "Активна:";
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Location = new Point(20, 150);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(113, 20);
            lblCreatedAt.TabIndex = 5;
            lblCreatedAt.Text = "Дата создания:";
            // 
            // lblCurrentBalance
            // 
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Location = new Point(20, 190);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(115, 20);
            lblCurrentBalance.TabIndex = 7;
            lblCurrentBalance.Text = "Баланс баллов:";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(140, 67);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.ReadOnly = true;
            txtCardNumber.Size = new Size(200, 27);
            txtCardNumber.TabIndex = 2;
            // 
            // txtIsActive
            // 
            txtIsActive.Location = new Point(140, 107);
            txtIsActive.Name = "txtIsActive";
            txtIsActive.ReadOnly = true;
            txtIsActive.Size = new Size(200, 27);
            txtIsActive.TabIndex = 4;
            // 
            // txtCreatedAt
            // 
            txtCreatedAt.Location = new Point(140, 147);
            txtCreatedAt.Name = "txtCreatedAt";
            txtCreatedAt.ReadOnly = true;
            txtCreatedAt.Size = new Size(200, 27);
            txtCreatedAt.TabIndex = 6;
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Location = new Point(140, 187);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.ReadOnly = true;
            txtCurrentBalance.Size = new Size(200, 27);
            txtCurrentBalance.TabIndex = 8;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 377);
            Controls.Add(lblTitle);
            Controls.Add(lblCardNumber);
            Controls.Add(txtCardNumber);
            Controls.Add(lblIsActive);
            Controls.Add(txtIsActive);
            Controls.Add(lblCreatedAt);
            Controls.Add(txtCreatedAt);
            Controls.Add(lblCurrentBalance);
            Controls.Add(txtCurrentBalance);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Личный кабинет";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
