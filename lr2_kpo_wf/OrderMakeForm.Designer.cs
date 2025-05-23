﻿namespace lr2_kpo_wf
{
    partial class OrderMakeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TreeView treeViewMenu;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox comboBoxCafes;
        private System.Windows.Forms.Button btnConfirmOrder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.comboBoxCafes = new System.Windows.Forms.ComboBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();

            this.SuspendLayout();

            // treeViewMenu
            this.treeViewMenu.Location = new System.Drawing.Point(12, 12);
            this.treeViewMenu.Size = new System.Drawing.Size(250, 300);
            this.treeViewMenu.TabIndex = 0;

            // numericQuantity
            this.numericQuantity.Location = new System.Drawing.Point(280, 12);
            this.numericQuantity.Minimum = 1;
            this.numericQuantity.Value = 1;
            this.numericQuantity.TabIndex = 1;

            // btnAddToOrder
            this.btnAddToOrder.Location = new System.Drawing.Point(280, 50);
            this.btnAddToOrder.Size = new System.Drawing.Size(150, 30);
            this.btnAddToOrder.Text = "Добавить в заказ";
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);

            // dgvOrder
            this.dgvOrder.Location = new System.Drawing.Point(12, 320);
            this.dgvOrder.Size = new System.Drawing.Size(600, 200);
            this.dgvOrder.Columns.Add("ProductName", "Продукт");
            this.dgvOrder.Columns.Add("Quantity", "Количество");
            this.dgvOrder.Columns.Add("UnitPrice", "Цена за ед.");
            this.dgvOrder.Columns.Add("TotalPrice", "Сумма");
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.RowHeadersVisible = false;

            // lblTotal
            this.lblTotal.Location = new System.Drawing.Point(12, 530);
            this.lblTotal.Size = new System.Drawing.Size(300, 30);
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotal.Text = "Итого: 0";

            // comboBoxCafes
            this.comboBoxCafes.Location = new System.Drawing.Point(320, 530);
            this.comboBoxCafes.Size = new System.Drawing.Size(200, 30);

            // btnConfirmOrder
            this.btnConfirmOrder.Location = new System.Drawing.Point(530, 530);
            this.btnConfirmOrder.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmOrder.Text = "Оформить";
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);

            // OrderMakeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 580);
            this.Controls.Add(this.treeViewMenu);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.comboBoxCafes);
            this.Controls.Add(this.btnConfirmOrder);
            this.Text = "Оформление заказа";

            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
