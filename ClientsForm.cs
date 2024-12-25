using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wzrehouse
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        // Добавить клиента
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridViewClients.Rows.Add(txtClientName.Text, txtPhoneNumber.Text, txtEmail.Text, txtAddress.Text);
            txtClientName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }

        // Удалить клиента
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                dataGridViewClients.Rows.RemoveAt(dataGridViewClients.SelectedRows[0].Index);
            }
        }
    }
}
