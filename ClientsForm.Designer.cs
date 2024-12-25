using System.Windows.Forms;

namespace Wzrehouse
{
    partial class ClientsForm
    {
            private System.ComponentModel.IContainer components = null;
            private DataGridView dataGridViewClients;
            private Button btnAdd;
            private Button btnDelete;
            private TextBox txtClientName;
            private TextBox txtPhoneNumber;
            private TextBox txtEmail;
            private TextBox txtAddress;
            private Label lblClientName;
            private Label lblPhoneNumber;
            private Label lblEmail;
            private Label lblAddress;

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
                this.dataGridViewClients = new System.Windows.Forms.DataGridView();
                this.btnAdd = new System.Windows.Forms.Button();
                this.btnDelete = new System.Windows.Forms.Button();
                this.txtClientName = new System.Windows.Forms.TextBox();
                this.txtPhoneNumber = new System.Windows.Forms.TextBox();
                this.txtEmail = new System.Windows.Forms.TextBox();
                this.txtAddress = new System.Windows.Forms.TextBox();
                this.lblClientName = new System.Windows.Forms.Label();
                this.lblPhoneNumber = new System.Windows.Forms.Label();
                this.lblEmail = new System.Windows.Forms.Label();
                this.lblAddress = new System.Windows.Forms.Label();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
                this.SuspendLayout();
                // 
                // dataGridViewClients
                // 
                this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dataGridViewClients.Location = new System.Drawing.Point(12, 130);
                this.dataGridViewClients.Name = "dataGridViewClients";
                this.dataGridViewClients.RowHeadersWidth = 51;
                this.dataGridViewClients.RowTemplate.Height = 29;
                this.dataGridViewClients.Size = new System.Drawing.Size(760, 300);
                this.dataGridViewClients.TabIndex = 0;
                // 
                // btnAdd
                // 
                this.btnAdd.Location = new System.Drawing.Point(540, 20);
                this.btnAdd.Name = "btnAdd";
                this.btnAdd.Size = new System.Drawing.Size(100, 29);
                this.btnAdd.TabIndex = 1;
                this.btnAdd.Text = "Добавить";
                this.btnAdd.UseVisualStyleBackColor = true;
                this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
                // 
                // btnDelete
                // 
                this.btnDelete.Location = new System.Drawing.Point(540, 65);
                this.btnDelete.Name = "btnDelete";
                this.btnDelete.Size = new System.Drawing.Size(100, 29);
                this.btnDelete.TabIndex = 2;
                this.btnDelete.Text = "Удалить";
                this.btnDelete.UseVisualStyleBackColor = true;
                this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
                // 
                // txtClientName
                // 
                this.txtClientName.Location = new System.Drawing.Point(12, 30);
                this.txtClientName.Name = "txtClientName";
                this.txtClientName.Size = new System.Drawing.Size(200, 27);
                this.txtClientName.TabIndex = 3;
                // 
                // txtPhoneNumber
                // 
                this.txtPhoneNumber.Location = new System.Drawing.Point(220, 30);
                this.txtPhoneNumber.Name = "txtPhoneNumber";
                this.txtPhoneNumber.Size = new System.Drawing.Size(150, 27);
                this.txtPhoneNumber.TabIndex = 4;
                // 
                // txtEmail
                // 
                this.txtEmail.Location = new System.Drawing.Point(12, 90);
                this.txtEmail.Name = "txtEmail";
                this.txtEmail.Size = new System.Drawing.Size(200, 27);
                this.txtEmail.TabIndex = 5;
                // 
                // txtAddress
                // 
                this.txtAddress.Location = new System.Drawing.Point(220, 90);
                this.txtAddress.Name = "txtAddress";
                this.txtAddress.Size = new System.Drawing.Size(300, 27);
                this.txtAddress.TabIndex = 6;
                // 
                // lblClientName
                // 
                this.lblClientName.AutoSize = true;
                this.lblClientName.Location = new System.Drawing.Point(12, 10);
                this.lblClientName.Name = "lblClientName";
                this.lblClientName.Size = new System.Drawing.Size(55, 20);
                this.lblClientName.TabIndex = 7;
                this.lblClientName.Text = "Клиент";
                // 
                // lblPhoneNumber
                // 
                this.lblPhoneNumber.AutoSize = true;
                this.lblPhoneNumber.Location = new System.Drawing.Point(220, 10);
                this.lblPhoneNumber.Name = "lblPhoneNumber";
                this.lblPhoneNumber.Size = new System.Drawing.Size(68, 20);
                this.lblPhoneNumber.TabIndex = 8;
                this.lblPhoneNumber.Text = "Телефон";
                // 
                // lblEmail
                // 
                this.lblEmail.AutoSize = true;
                this.lblEmail.Location = new System.Drawing.Point(12, 70);
                this.lblEmail.Name = "lblEmail";
                this.lblEmail.Size = new System.Drawing.Size(46, 20);
                this.lblEmail.TabIndex = 9;
                this.lblEmail.Text = "Email";
                // 
                // lblAddress
                // 
                this.lblAddress.AutoSize = true;
                this.lblAddress.Location = new System.Drawing.Point(220, 70);
                this.lblAddress.Name = "lblAddress";
                this.lblAddress.Size = new System.Drawing.Size(51, 20);
                this.lblAddress.TabIndex = 10;
                this.lblAddress.Text = "Адрес";
                // 
                // ClientsForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(784, 450);
                this.Controls.Add(this.lblAddress);
                this.Controls.Add(this.lblEmail);
                this.Controls.Add(this.lblPhoneNumber);
                this.Controls.Add(this.lblClientName);
                this.Controls.Add(this.txtAddress);
                this.Controls.Add(this.txtEmail);
                this.Controls.Add(this.txtPhoneNumber);
                this.Controls.Add(this.txtClientName);
                this.Controls.Add(this.btnDelete);
                this.Controls.Add(this.btnAdd);
                this.Controls.Add(this.dataGridViewClients);
                this.Name = "ClientsForm";
                this.Text = "Управление клиентами";
                ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }
}