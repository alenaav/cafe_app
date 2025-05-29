namespace lr2_kpo_wf
{
    partial class CardNumberPromptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNext = new Button();
            txtCardNumber = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Location = new Point(164, 187);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(185, 55);
            btnNext.TabIndex = 0;
            btnNext.Text = "Далее";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(89, 141);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(345, 27);
            txtCardNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 101);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 2;
            label1.Text = "Введите номер карты клиента";
            // 
            // CardNumberPromptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 323);
            Controls.Add(label1);
            Controls.Add(txtCardNumber);
            Controls.Add(btnNext);
            Name = "CardNumberPromptForm";
            Text = "CardNumberPromptForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNext;
        private TextBox txtCardNumber;
        private Label label1;
    }
}