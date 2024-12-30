using System.Windows.Forms;

namespace Wzrehouse
{
    partial class GoodsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewGoods;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtOwner;
        private TextBox txtWarehouse;
        private Label lblName;
        private Label lblQuantity;
        private Label lblOwner;
        private Label lblWarehouse;
        private Label lblDateReceived;
        private DateTimePicker dateTimePickerReceived;
        private Button btnSave;  // Объявляем кнопку "Сохранить"


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
            this.dataGridViewGoods = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtWarehouse = new System.Windows.Forms.TextBox();
            this.dateTimePickerReceived = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGoods
            // 
            this.dataGridViewGoods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewGoods.Location = new System.Drawing.Point(12, 180);
            this.dataGridViewGoods.Name = "dataGridViewGoods";
            this.dataGridViewGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGoods.Size = new System.Drawing.Size(959, 250);
            this.dataGridViewGoods.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Владелец";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Склад";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата поступления";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(219, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(120, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(345, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(120, 50);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(345, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtOwner
            // 
            this.txtOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwner.Location = new System.Drawing.Point(120, 80);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(345, 20);
            this.txtOwner.TabIndex = 5;
            // 
            // txtWarehouse
            // 
            this.txtWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWarehouse.Location = new System.Drawing.Point(120, 110);
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.Size = new System.Drawing.Size(345, 20);
            this.txtWarehouse.TabIndex = 6;
            // 
            // dateTimePickerReceived
            // 
            this.dateTimePickerReceived.Location = new System.Drawing.Point(120, 140);
            this.dateTimePickerReceived.Name = "dateTimePickerReceived";
            this.dateTimePickerReceived.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReceived.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Название ТМЦ:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 50);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 13);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Количество:";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(12, 80);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(59, 13);
            this.lblOwner.TabIndex = 10;
            this.lblOwner.Text = "Владелец:";
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(12, 110);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(41, 13);
            this.lblWarehouse.TabIndex = 11;
            this.lblWarehouse.Text = "Склад:";
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Location = new System.Drawing.Point(12, 140);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(103, 13);
            this.lblDateReceived.TabIndex = 12;
            this.lblDateReceived.Text = "Дата поступления:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(429, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GoodsForm
            // 
            this.ClientSize = new System.Drawing.Size(983, 491);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDateReceived);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dateTimePickerReceived);
            this.Controls.Add(this.txtWarehouse);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewGoods);
            this.Name = "GoodsForm";
            this.Text = "Управление ТМЦ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}