namespace Wzrehouse
{
    partial class EditWarehouseForm
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.ComboBox cmbWarehouseType;
        private System.Windows.Forms.Button btnAddWarehouse;
        private System.Windows.Forms.Button btnDeleteWarehouse;
        private System.Windows.Forms.DataGridView dataGridViewWarehouses;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblWarehouseType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

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

        private void InitializeComponent()
        {
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.cmbWarehouseType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblWarehouseType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(103, 17);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(157, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.Location = new System.Drawing.Point(103, 52);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(157, 20);
            this.txtArea.TabIndex = 1;
            // 
            // cmbWarehouseType
            // 
            this.cmbWarehouseType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWarehouseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouseType.FormattingEnabled = true;
            this.cmbWarehouseType.Items.AddRange(new object[] {
            "Продукты",
            "Холодильники",
            "Строительные материалы",
            "Металлопрокат"});
            this.cmbWarehouseType.Location = new System.Drawing.Point(103, 87);
            this.cmbWarehouseType.Name = "cmbWarehouseType";
            this.cmbWarehouseType.Size = new System.Drawing.Size(157, 21);
            this.cmbWarehouseType.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 26);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(171, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 26);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 20);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Адрес:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(17, 55);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(57, 13);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Площадь:";
            // 
            // lblWarehouseType
            // 
            this.lblWarehouseType.AutoSize = true;
            this.lblWarehouseType.Location = new System.Drawing.Point(17, 89);
            this.lblWarehouseType.Name = "lblWarehouseType";
            this.lblWarehouseType.Size = new System.Drawing.Size(29, 13);
            this.lblWarehouseType.TabIndex = 7;
            this.lblWarehouseType.Text = "Тип:";
            // 
            // EditWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 173);
            this.Controls.Add(this.lblWarehouseType);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbWarehouseType);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtAddress);
            this.Name = "EditWarehouseForm";
            this.Text = "Редактирование склада";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
