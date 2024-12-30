using System;
using System.Windows.Forms;

namespace Wzrehouse
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            InitializeDataGridViewColumns(); // Убедимся, что столбцы добавлены
        }

        // Метод для инициализации столбцов в DataGridView
        private void InitializeDataGridViewColumns()
        {
            if (dataGridViewClients.Columns.Count == 0) // Проверяем, если столбцы отсутствуют
            {
                dataGridViewClients.Columns.Add("ClientName", "Имя клиента");
                dataGridViewClients.Columns.Add("PhoneNumber", "Номер телефона");
                dataGridViewClients.Columns.Add("Email", "Электронная почта");
                dataGridViewClients.Columns.Add("Address", "Адрес");
            }
        }

        // Добавить клиента
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Убедимся, что все поля заполнены
            if (string.IsNullOrWhiteSpace(txtClientName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Заполните все поля перед добавлением клиента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Добавляем данные в DataGridView
            dataGridViewClients.Rows.Add(txtClientName.Text, txtPhoneNumber.Text, txtEmail.Text, txtAddress.Text);

            // Очищаем поля ввода
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
            else
            {
                MessageBox.Show("Выберите строку для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
