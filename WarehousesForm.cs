using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using static Wzrehouse.GoodsForm;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Wzrehouse
{
    public partial class WarehousesForm : Form
    {
        public List<Warehouse> warehouses = new List<Warehouse>();
         

        public WarehousesForm()
        {
            InitializeComponent();
            
            LoadData();
        }

        
            private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            // Проверка на корректность ввода
            if (string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtArea.Text) ||
                cmbWarehouseType.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создание нового склада
            Warehouse newWarehouse = new Warehouse
            {
                Address = txtAddress.Text,
                Area = double.TryParse(txtArea.Text, out var area) ? area : 0,
                Type = cmbWarehouseType.SelectedItem.ToString()
            };

            warehouses.Add(newWarehouse);

            // Обновление интерфейса
            UpdateGridView();
            SaveData();
        }

        private void btnDeleteWarehouse_Click(object sender, EventArgs e)
        {
            if (dataGridViewWarehouses.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewWarehouses.SelectedRows[0].Index;
                warehouses.RemoveAt(selectedIndex);

                UpdateGridView();
                SaveData();
            }
            else
            {
                MessageBox.Show("Выберите склад для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                string filePath = "warehouse.json";

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    warehouses = JsonConvert.DeserializeObject<List<Warehouse>>(json) ?? new List<Warehouse>();
                    UpdateGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из файла: " + ex.Message, "Ошибка");
            }
        }

        private void SaveData()
        {
            try
            {
                string filePath = "warehouse.json";
                string json = JsonConvert.SerializeObject(warehouses, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных в файл: " + ex.Message, "Ошибка");
            }
        }

        private void UpdateGridView()
        {
            dataGridViewWarehouses.DataSource = null;
            dataGridViewWarehouses.DataSource = warehouses;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные сохранены успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SaveData();
        }

        private void btnEditWarehouse_Click(object sender, EventArgs e)
        {
            if (dataGridViewWarehouses.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewWarehouses.SelectedRows[0].Index;
                Warehouse selectedWarehouse = warehouses[selectedIndex];

                using (EditWarehouseForm editForm = new EditWarehouseForm(selectedWarehouse))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        warehouses[selectedIndex] = editForm.EditedWarehouse;
                        UpdateGridView();
                        SaveData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите склад для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbackForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
