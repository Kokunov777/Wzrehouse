using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Wzrehouse
{
    public partial class WarehousesForm : Form
    {
        // Список для хранения данных о складах
        private List<Warehouse> warehouses = new List<Warehouse>();

        public WarehousesForm()
        {
            InitializeComponent();
        }

        // Обновление таблицы DataGridView
        private void UpdateTable()
        {
            dataGridViewWarehouses.Rows.Clear();
            foreach (var warehouse in warehouses)
            {
                dataGridViewWarehouses.Rows.Add(warehouse.Address, warehouse.Area, warehouse.Type);
            }
        }

        // Добавление склада
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtArea.Text) ||
                string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Добавляем новый склад в список
            Warehouse warehouse = new Warehouse
            {
                Address = txtAddress.Text,
                Area = Convert.ToDouble(txtArea.Text),
                Type = txtType.Text
            };

            warehouses.Add(warehouse);
            UpdateTable();
            ClearInputs();
        }

        // Удаление склада
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewWarehouses.SelectedRows.Count > 0)
            {
                int index = dataGridViewWarehouses.SelectedRows[0].Index;
                warehouses.RemoveAt(index);
                UpdateTable();
            }
            else
            {
                MessageBox.Show("Выберите склад для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Очистка полей ввода
        private void ClearInputs()
        {
            txtAddress.Clear();
            txtArea.Clear();
            txtType.Clear();
        }
    }

    // Класс для описания склада
    public class Warehouse
    {
        public string Address { get; set; }
        public double Area { get; set; }
        public string Type { get; set; }
    }
}
