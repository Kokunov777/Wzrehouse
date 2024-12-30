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
    public partial class EditWarehouseForm : Form
    {
        public Warehouse EditedWarehouse { get; private set; }

        public EditWarehouseForm(Warehouse warehouse)
        {
            InitializeComponent();
            // Заполнение полей формы данными из переданного склада
            txtAddress.Text = warehouse.Address;
            txtArea.Text = warehouse.Area.ToString();
            cmbWarehouseType.SelectedItem = warehouse.Type;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверка корректности ввода
            if (string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtArea.Text) ||
                cmbWarehouseType.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Обновление свойств редактируемого склада
            EditedWarehouse = new Warehouse
            {
                Address = txtAddress.Text,
                Area = double.TryParse(txtArea.Text, out var area) ? area : 0,
                Type = cmbWarehouseType.SelectedItem.ToString()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
