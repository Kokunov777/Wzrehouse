using System.Windows.Forms;

namespace Wzrehouse
{
    partial class WarehousesForm
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
            this.btnAddWarehouse = new System.Windows.Forms.Button();
            this.btnDeleteWarehouse = new System.Windows.Forms.Button();
            this.dataGridViewWarehouses = new System.Windows.Forms.DataGridView();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblWarehouseType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditWarehouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouses)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(103, 17);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(119, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.Location = new System.Drawing.Point(103, 52);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(119, 20);
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
            "Металлопрокат",
            "Учебное заведение",
            "АвтоСклад",
            "ХимСтанция",
            "Военная техника",
            "Ангары"
            });
            this.cmbWarehouseType.Location = new System.Drawing.Point(103, 87);
            this.cmbWarehouseType.Name = "cmbWarehouseType";
            this.cmbWarehouseType.Size = new System.Drawing.Size(119, 21);
            this.cmbWarehouseType.TabIndex = 2;
            // 
            // btnAddWarehouse
            // 
            this.btnAddWarehouse.Location = new System.Drawing.Point(17, 319);
            this.btnAddWarehouse.Name = "btnAddWarehouse";
            this.btnAddWarehouse.Size = new System.Drawing.Size(86, 26);
            this.btnAddWarehouse.TabIndex = 3;
            this.btnAddWarehouse.Text = "Добавить";
            this.btnAddWarehouse.UseVisualStyleBackColor = true;
            this.btnAddWarehouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
            // 
            // btnDeleteWarehouse
            // 
            this.btnDeleteWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteWarehouse.Location = new System.Drawing.Point(490, 324);
            this.btnDeleteWarehouse.Name = "btnDeleteWarehouse";
            this.btnDeleteWarehouse.Size = new System.Drawing.Size(86, 26);
            this.btnDeleteWarehouse.TabIndex = 4;
            this.btnDeleteWarehouse.Text = "Удалить";
            this.btnDeleteWarehouse.UseVisualStyleBackColor = true;
            this.btnDeleteWarehouse.Click += new System.EventHandler(this.btnDeleteWarehouse_Click);
            // 
            // dataGridViewWarehouses
            // 
            this.dataGridViewWarehouses.AllowUserToAddRows = false;
            this.dataGridViewWarehouses.AllowUserToDeleteRows = false;
            this.dataGridViewWarehouses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewWarehouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouses.Location = new System.Drawing.Point(17, 130);
            this.dataGridViewWarehouses.MultiSelect = false;
            this.dataGridViewWarehouses.Name = "dataGridViewWarehouses";
            this.dataGridViewWarehouses.ReadOnly = true;
            this.dataGridViewWarehouses.RowTemplate.Height = 25;
            this.dataGridViewWarehouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWarehouses.Size = new System.Drawing.Size(575, 173);
            this.dataGridViewWarehouses.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 20);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Адрес:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(17, 55);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(57, 13);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Площадь:";
            // 
            // lblWarehouseType
            // 
            this.lblWarehouseType.AutoSize = true;
            this.lblWarehouseType.Location = new System.Drawing.Point(17, 89);
            this.lblWarehouseType.Name = "lblWarehouseType";
            this.lblWarehouseType.Size = new System.Drawing.Size(29, 13);
            this.lblWarehouseType.TabIndex = 8;
            this.lblWarehouseType.Text = "Тип:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(368, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditWarehouse
            // 
            this.btnEditWarehouse.Location = new System.Drawing.Point(124, 319);
            this.btnEditWarehouse.Name = "btnEditWarehouse";
            this.btnEditWarehouse.Size = new System.Drawing.Size(120, 26);
            this.btnEditWarehouse.TabIndex = 10;
            this.btnEditWarehouse.Text = "редоктировать";
            this.btnEditWarehouse.UseVisualStyleBackColor = true;
            this.btnEditWarehouse.Click += new System.EventHandler(this.btnEditWarehouse_Click);
            // 
            // WarehousesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 388);
            this.Controls.Add(this.btnEditWarehouse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblWarehouseType);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.dataGridViewWarehouses);
            this.Controls.Add(this.btnDeleteWarehouse);
            this.Controls.Add(this.btnAddWarehouse);
            this.Controls.Add(this.cmbWarehouseType);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtAddress);
            this.Name = "WarehousesForm";
            this.Text = "Управление складами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnSave;
        private Button btnEditWarehouse;
    }
}
