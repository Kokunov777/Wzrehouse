using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Wzrehouse
{
    public partial class GoodsForm : Form
    {
        // Список для хранения данных о ТМЦ
        private List<Goods> goodsList = new List<Goods>();

        public GoodsForm()
        {
            InitializeComponent();
            LoadData();
            UpdateTable();
        }

       
        // Обновление таблицы DataGridView
        private void UpdateTable()
        {
            
            dataGridViewGoods.Rows.Clear();

           
            if (dataGridViewGoods.Columns.Count == 0)
            {
            
                dataGridViewGoods.Columns.Add("ColumnName", "Название");
                dataGridViewGoods.Columns.Add("ColumnQuantity", "Количество");
                dataGridViewGoods.Columns.Add("ColumnOwner", "Владелец");
                dataGridViewGoods.Columns.Add("ColumnWarehouse", "Склад");
                dataGridViewGoods.Columns.Add("ColumnDateReceived", "Дата поступления");
            }


            foreach (var goods in goodsList)
            {
                
                dataGridViewGoods.Rows.Add(goods.Name, goods.Quantity, goods.Owner, goods.Warehouse, goods.DateReceived.ToString("yyyy-MM-dd"));
            }
        }


        // Добавление ТМЦ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtOwner.Text) ||
                string.IsNullOrWhiteSpace(txtWarehouse.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Добавляем новый ТМЦ в список
            Goods goods = new Goods
            {
                Name = txtName.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                Owner = txtOwner.Text,
                Warehouse = txtWarehouse.Text,
                DateReceived = dateTimePickerReceived.Value
            };

            goodsList.Add(goods);
            UpdateTable();
            ClearInputs();
            
        }

        // Удаление ТМЦ
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewGoods.SelectedRows.Count > 0)
            {
                int index = dataGridViewGoods.SelectedRows[0].Index;
                goodsList.RemoveAt(index);
                UpdateTable();
               
            }
            else
            {
                MessageBox.Show("Выберите ТМЦ для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Очистка полей ввода
        private void ClearInputs()
        {
            txtName.Clear();
            txtQuantity.Clear();
            txtOwner.Clear();
            txtWarehouse.Clear();
            dateTimePickerReceived.Value = DateTime.Now;
        }


  
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Указываем путь для сохранения файла (можно изменить на ваш выбор)
            string filePath = "goodsData.json";

            try
            {
                string json = JsonConvert.SerializeObject(goodsList, Formatting.Indented);
                File.WriteAllText(filePath, json);

                MessageBox.Show("Данные успешно сохранены в формате JSON!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            string filePath = "goodsData.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    goodsList = JsonConvert.DeserializeObject<List<Goods>>(json) ?? new List<Goods>();
                    UpdateTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Класс для описания ТМЦ
        public class Goods
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public string Owner { get; set; }
            public string Warehouse { get; set; }
            public DateTime DateReceived { get; set; }
        }

        private void GoodsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
