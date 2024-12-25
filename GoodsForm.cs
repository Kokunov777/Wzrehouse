using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Wzrehouse
{
    public partial class GoodsForm : Form
    {
        // Список для хранения данных о ТМЦ
        private List<Goods> goodsList = new List<Goods>();

        public GoodsForm()
        {
            InitializeComponent();
        }

        // Обновление таблицы DataGridView
        private void UpdateTable()
        {
            dataGridViewGoods.Rows.Clear();
            foreach (var goods in goodsList)
            {
                dataGridViewGoods.Rows.Add(goods.Name, goods.Quantity, goods.Owner, goods.Warehouse, goods.DateReceived);
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
}

