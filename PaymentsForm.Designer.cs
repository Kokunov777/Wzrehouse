using System.Windows.Forms;

namespace Wzrehouse
{
    partial class PaymentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewPayments;
        private Button btnAddPayment;
        private Button btnDeletePayment;
        private TextBox txtPaymentAmount;
        private ComboBox cmbPaymentMethod;
        private DateTimePicker dtpPaymentDate;
        private TextBox txtClientName;
        private Label lblPaymentAmount;
        private Label lblPaymentMethod;
        private Label lblPaymentDate;
        private Label lblClientName;

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
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.RowHeadersWidth = 51;
            this.dataGridViewPayments.RowTemplate.Height = 29;
            this.dataGridViewPayments.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewPayments.TabIndex = 0;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(540, 20);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(100, 29);
            this.btnAddPayment.TabIndex = 1;
            this.btnAddPayment.Text = "Добавить";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(540, 65);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(100, 29);
            this.btnDeletePayment.TabIndex = 2;
            this.btnDeletePayment.Text = "Удалить";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
          //  this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(12, 30);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(150, 27);
            this.txtPaymentAmount.TabIndex = 3;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Наличный расчет",
            "Безналичный расчет"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(170, 30);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(200, 28);
            this.cmbPaymentMethod.TabIndex = 4;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(380, 30);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(150, 27);
            this.dtpPaymentDate.TabIndex = 5;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(12, 90);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(200, 27);
            this.txtClientName.TabIndex = 6;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(12, 10);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(98, 20);
            this.lblPaymentAmount.TabIndex = 7;
            this.lblPaymentAmount.Text = "Сумма оплаты";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(170, 10);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(117, 20);
            this.lblPaymentMethod.TabIndex = 8;
            this.lblPaymentMethod.Text = "Способ оплаты";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(380, 10);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(98, 20);
            this.lblPaymentDate.TabIndex = 9;
            this.lblPaymentDate.Text = "Дата оплаты";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(12, 70);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(55, 20);
            this.lblClientName.TabIndex = 10;
            this.lblClientName.Text = "Клиент";
            // 
            // PaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.dataGridViewPayments);
            this.Name = "PaymentsForm";
            this.Text = "Управление оплатами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
