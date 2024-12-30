using System.Windows.Forms;

namespace Wzrehouse
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxReportType;
        private Button btnGenerateReport;
        private DataGridView dataGridViewReports;
        private Label lblReportType;

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
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            this.lblReportType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Items.AddRange(new object[] {
            "Сводка по складам",
            "Сводка по ТМЦ",
            "Истекающие договоры",
            "Платежи арендаторов"});
            this.comboBoxReportType.Location = new System.Drawing.Point(9, 19);
            this.comboBoxReportType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(188, 21);
            this.comboBoxReportType.TabIndex = 0;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(210, 19);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(112, 19);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Сформировать отчет";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.AllowUserToAddRows = false;
            this.dataGridViewReports.AllowUserToDeleteRows = false;
            this.dataGridViewReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Location = new System.Drawing.Point(9, 49);
            this.dataGridViewReports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.ReadOnly = true;
            this.dataGridViewReports.RowHeadersWidth = 51;
            this.dataGridViewReports.RowTemplate.Height = 29;
            this.dataGridViewReports.Size = new System.Drawing.Size(570, 227);
            this.dataGridViewReports.TabIndex = 2;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(9, 6);
            this.lblReportType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(62, 13);
            this.lblReportType.TabIndex = 3;
            this.lblReportType.Text = "Тип отчета";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 292);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.dataGridViewReports);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.comboBoxReportType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportsForm";
            this.Text = "Отчеты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}