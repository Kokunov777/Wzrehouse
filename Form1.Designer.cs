using System.Windows.Forms;

namespace Wzrehouse
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnWarehouses;
        private Button btnInventory;
        private Button btnContracts;
        private Button btnReports;
        private Button btnExit;
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
            this.btnWarehouses = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWarehouses
            // 
            this.btnWarehouses.Location = new System.Drawing.Point(90, 66);
            this.btnWarehouses.Margin = new System.Windows.Forms.Padding(2);
            this.btnWarehouses.Name = "btnWarehouses";
            this.btnWarehouses.Size = new System.Drawing.Size(150, 32);
            this.btnWarehouses.TabIndex = 0;
            this.btnWarehouses.Text = "Управление складами";
            this.btnWarehouses.UseVisualStyleBackColor = true;
            this.btnWarehouses.Click += new System.EventHandler(this.btnWarehouses_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(90, 111);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(150, 32);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Управление ТМЦ";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(90, 157);
            this.btnContracts.Margin = new System.Windows.Forms.Padding(2);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(150, 32);
            this.btnContracts.TabIndex = 2;
            this.btnContracts.Text = "Управление договорами";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(90, 306);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 32);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Отчеты";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(90, 355);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(38, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Система управления складами";
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(90, 206);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(150, 34);
            this.btnClients.TabIndex = 6;
            this.btnClients.Text = "Склиент";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click_1);
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(90, 255);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(150, 34);
            this.btnPayments.TabIndex = 7;
            this.btnPayments.Text = "оплата";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 416);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnWarehouses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnClients;
        private Button btnPayments;
    }
}

