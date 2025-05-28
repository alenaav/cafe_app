namespace lr2_kpo_wf
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblCardNumber;
        private Label lblCardNumberValue;      // Для отображения значения номера карты
        private Label lblIsActive;
        private Label lblIsActiveValue;        // Для отображения статуса активности
        private Label lblCreatedAt;
        private Label lblCreatedAtValue;       // Для отображения даты создания
        private Label lblCurrentBalance;
        private Label lblCurrentBalanceValue;  // Для отображения баланса баллов
        private Label lblLevel;
        private Label lblLevelValue;           // Для отображения уровня

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
            lblCardNumberValue = new Label();
            lblIsActive = new Label();
            lblIsActiveValue = new Label();
            lblCreatedAt = new Label();
            lblCreatedAtValue = new Label();
            lblCurrentBalance = new Label();
            lblCurrentBalanceValue = new Label();
            lblLevel = new Label();
            lblLevelValue = new Label();

            menuStrip1 = new MenuStrip();
            историяЗаказовToolStripMenuItem = new ToolStripMenuItem();
            историяКартыToolStripMenuItem = new ToolStripMenuItem();
            списокКафеToolStripMenuItem = new ToolStripMenuItem();
            профильToolStripMenuItem = new ToolStripMenuItem();

            menuStrip1.SuspendLayout();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(397, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Карта лояльности пользователя";

            // lblCardNumber
            lblCardNumber.AutoSize = true;
            lblCardNumber.Location = new Point(20, 70);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(105, 20);
            lblCardNumber.TabIndex = 1;
            lblCardNumber.Text = "Номер карты:";

            // lblCardNumberValue
            lblCardNumberValue.AutoSize = true;
            lblCardNumberValue.Location = new Point(140, 70);
            lblCardNumberValue.Name = "lblCardNumberValue";
            lblCardNumberValue.Size = new Size(200, 20);
            lblCardNumberValue.TabIndex = 2;
            lblCardNumberValue.Text = "";

            // lblIsActive
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(20, 110);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(69, 20);
            lblIsActive.TabIndex = 3;
            lblIsActive.Text = "Активна:";

            // lblIsActiveValue
            lblIsActiveValue.AutoSize = true;
            lblIsActiveValue.Location = new Point(140, 110);
            lblIsActiveValue.Name = "lblIsActiveValue";
            lblIsActiveValue.Size = new Size(200, 20);
            lblIsActiveValue.TabIndex = 4;
            lblIsActiveValue.Text = "";

            // lblCreatedAt
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Location = new Point(20, 150);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(113, 20);
            lblCreatedAt.TabIndex = 5;
            lblCreatedAt.Text = "Дата создания:";

            // lblCreatedAtValue
            lblCreatedAtValue.AutoSize = true;
            lblCreatedAtValue.Location = new Point(140, 150);
            lblCreatedAtValue.Name = "lblCreatedAtValue";
            lblCreatedAtValue.Size = new Size(200, 20);
            lblCreatedAtValue.TabIndex = 6;
            lblCreatedAtValue.Text = "";

            // lblCurrentBalance
            lblCurrentBalance.AutoSize = true;
            lblCurrentBalance.Location = new Point(20, 190);
            lblCurrentBalance.Name = "lblCurrentBalance";
            lblCurrentBalance.Size = new Size(115, 20);
            lblCurrentBalance.TabIndex = 7;
            lblCurrentBalance.Text = "Баланс баллов:";

            // lblCurrentBalanceValue
            lblCurrentBalanceValue.AutoSize = true;
            lblCurrentBalanceValue.Location = new Point(140, 190);
            lblCurrentBalanceValue.Name = "lblCurrentBalanceValue";
            lblCurrentBalanceValue.Size = new Size(200, 20);
            lblCurrentBalanceValue.TabIndex = 8;
            lblCurrentBalanceValue.Text = "";

            // lblLevel
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(20, 230);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(65, 20);
            lblLevel.TabIndex = 9;
            lblLevel.Text = "Уровень:";

            // lblLevelValue
            lblLevelValue.AutoSize = true;
            lblLevelValue.Location = new Point(140, 230);
            lblLevelValue.Name = "lblLevelValue";
            lblLevelValue.Size = new Size(200, 20);
            lblLevelValue.TabIndex = 10;
            lblLevelValue.Text = "";

            // menuStrip1
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { историяЗаказовToolStripMenuItem, историяКартыToolStripMenuItem, списокКафеToolStripMenuItem, профильToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(557, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";

            // историяЗаказовToolStripMenuItem
            историяЗаказовToolStripMenuItem.Name = "историяЗаказовToolStripMenuItem";
            историяЗаказовToolStripMenuItem.Size = new Size(140, 24);
            историяЗаказовToolStripMenuItem.Text = "История заказов";
            историяЗаказовToolStripMenuItem.Click += историяЗаказовToolStripMenuItem_Click;

            // историяКартыToolStripMenuItem
            историяКартыToolStripMenuItem.Name = "историяКартыToolStripMenuItem";
            историяКартыToolStripMenuItem.Size = new Size(127, 24);
            историяКартыToolStripMenuItem.Text = "История карты";
            историяКартыToolStripMenuItem.Click += историяКартыToolStripMenuItem_Click;

            // списокКафеToolStripMenuItem
            списокКафеToolStripMenuItem.Name = "списокКафеToolStripMenuItem";
            списокКафеToolStripMenuItem.Size = new Size(110, 24);
            списокКафеToolStripMenuItem.Text = "Список кафе";
            списокКафеToolStripMenuItem.Click += списокКафеToolStripMenuItem_Click;

            // профильToolStripMenuItem
            профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            профильToolStripMenuItem.Size = new Size(87, 24);
            профильToolStripMenuItem.Text = "Профиль";
            профильToolStripMenuItem.Click += профильToolStripMenuItem_Click;

            // UserForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 377);
            Controls.Add(lblTitle);
            Controls.Add(lblCardNumber);
            Controls.Add(lblCardNumberValue);
            Controls.Add(lblIsActive);
            Controls.Add(lblIsActiveValue);
            Controls.Add(lblCreatedAt);
            Controls.Add(lblCreatedAtValue);
            Controls.Add(lblCurrentBalance);
            Controls.Add(lblCurrentBalanceValue);
            Controls.Add(lblLevel);
            Controls.Add(lblLevelValue);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Личный кабинет";
            Load += UserForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem историяЗаказовToolStripMenuItem;
        private ToolStripMenuItem историяКартыToolStripMenuItem;
        private ToolStripMenuItem списокКафеToolStripMenuItem;
        private ToolStripMenuItem профильToolStripMenuItem;
    }
}
