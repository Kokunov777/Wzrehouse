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
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 416);
           
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

