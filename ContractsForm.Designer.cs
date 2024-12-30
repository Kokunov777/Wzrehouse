using System.Windows.Forms;

namespace Wzrehouse
{
    partial class ContractsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewContracts;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtContractNumber;
        private TextBox txtTenantName;
        private TextBox txtWarehouse;
        private Label lblContractNumber;
        private Label lblTenantName;
        private Label lblWarehouse;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblIsPaid;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private CheckBox checkBoxIsPaid;

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
            this.dataGridViewContracts = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtContractNumber = new System.Windows.Forms.TextBox();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.txtWarehouse = new System.Windows.Forms.TextBox();
            this.lblContractNumber = new System.Windows.Forms.Label();
            this.lblTenantName = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblIsPaid = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.checkBoxIsPaid = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContracts
            // 
            this.dataGridViewContracts.AllowUserToAddRows = false;
            this.dataGridViewContracts.AllowUserToDeleteRows = false;
            this.dataGridViewContracts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContracts.Location = new System.Drawing.Point(9, 98);
            this.dataGridViewContracts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewContracts.Name = "dataGridViewContracts";
            this.dataGridViewContracts.ReadOnly = true;
            this.dataGridViewContracts.RowHeadersWidth = 51;
            this.dataGridViewContracts.RowTemplate.Height = 29;
            this.dataGridViewContracts.Size = new System.Drawing.Size(552, 162);
            this.dataGridViewContracts.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 273);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 19);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 273);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 19);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtContractNumber
            // 
            this.txtContractNumber.Location = new System.Drawing.Point(9, 20);
            this.txtContractNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContractNumber.Name = "txtContractNumber";
            this.txtContractNumber.Size = new System.Drawing.Size(104, 20);
            this.txtContractNumber.TabIndex = 3;
            // 
            // txtTenantName
            // 
            this.txtTenantName.Location = new System.Drawing.Point(135, 20);
            this.txtTenantName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(141, 20);
            this.txtTenantName.TabIndex = 4;
            // 
            // txtWarehouse
            // 
            this.txtWarehouse.Location = new System.Drawing.Point(300, 20);
            this.txtWarehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.Size = new System.Drawing.Size(104, 20);
            this.txtWarehouse.TabIndex = 5;
            // 
            // lblContractNumber
            // 
            this.lblContractNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContractNumber.AutoSize = true;
            this.lblContractNumber.Location = new System.Drawing.Point(9, 6);
            this.lblContractNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContractNumber.Name = "lblContractNumber";
            this.lblContractNumber.Size = new System.Drawing.Size(91, 13);
            this.lblContractNumber.TabIndex = 6;
            this.lblContractNumber.Text = "Номер договора";
            // 
            // lblTenantName
            // 
            this.lblTenantName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenantName.AutoSize = true;
            this.lblTenantName.Location = new System.Drawing.Point(135, 6);
            this.lblTenantName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenantName.Name = "lblTenantName";
            this.lblTenantName.Size = new System.Drawing.Size(61, 13);
            this.lblTenantName.TabIndex = 7;
            this.lblTenantName.Text = "Арендатор";
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(300, 6);
            this.lblWarehouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(38, 13);
            this.lblWarehouse.TabIndex = 8;
            this.lblWarehouse.Text = "Склад";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(9, 46);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(71, 13);
            this.lblStartDate.TabIndex = 9;
            this.lblStartDate.Text = "Дата начала";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(135, 46);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(89, 13);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "Дата окончания";
            // 
            // lblIsPaid
            // 
            this.lblIsPaid.AutoSize = true;
            this.lblIsPaid.Location = new System.Drawing.Point(300, 46);
            this.lblIsPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsPaid.Name = "lblIsPaid";
            this.lblIsPaid.Size = new System.Drawing.Size(56, 13);
            this.lblIsPaid.TabIndex = 11;
            this.lblIsPaid.Text = "Оплачено";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(9, 58);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(104, 20);
            this.dateTimePickerStart.TabIndex = 12;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(135, 58);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerEnd.TabIndex = 13;
            // 
            // checkBoxIsPaid
            // 
            this.checkBoxIsPaid.AutoSize = true;
            this.checkBoxIsPaid.Location = new System.Drawing.Point(300, 60);
            this.checkBoxIsPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxIsPaid.Name = "checkBoxIsPaid";
            this.checkBoxIsPaid.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsPaid.TabIndex = 14;
            this.checkBoxIsPaid.UseVisualStyleBackColor = true;
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 306);
            this.Controls.Add(this.checkBoxIsPaid);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.lblIsPaid);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.lblTenantName);
            this.Controls.Add(this.lblContractNumber);
            this.Controls.Add(this.txtWarehouse);
            this.Controls.Add(this.txtTenantName);
            this.Controls.Add(this.txtContractNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewContracts);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ContractsForm";
            this.Text = "Управление договорами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
