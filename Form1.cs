using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wzrehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWarehouses_Click(object sender, EventArgs e)
        {
            WarehousesForm warehousesForm = new WarehousesForm();
            warehousesForm.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            GoodsForm inventoryForm = new GoodsForm();
            inventoryForm.Show();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            ContractsForm contractsForm = new ContractsForm();
            contractsForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClients_Click_1(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            PaymentsForm paymentsForm = new PaymentsForm();
            paymentsForm.Show();
        }
    }
}
