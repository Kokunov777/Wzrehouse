using System;
using System.Windows.Forms;

namespace Wzrehouse
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        // Метод для добавления столбцов в DataGridView
        private void InitializeDataGridViewColumns(string reportType)
        {
            dataGridViewReports.Columns.Clear(); // Удаляем все существующие столбцы перед добавлением новых

            if (reportType == "Сводка по складам")
            {
                dataGridViewReports.Columns.Add("WarehouseName", "Склад");
                dataGridViewReports.Columns.Add("Category", "Категория");
                dataGridViewReports.Columns.Add("TotalArea", "Общая площадь");
                dataGridViewReports.Columns.Add("FreeSpace", "Свободное место");
            }
            else if (reportType == "Сводка по ТМЦ")
            {
                dataGridViewReports.Columns.Add("GoodsName", "Товар");
                dataGridViewReports.Columns.Add("WarehouseName", "Склад");
                dataGridViewReports.Columns.Add("Tenant", "Арендатор");
                dataGridViewReports.Columns.Add("Quantity", "Количество");
            }
            else if (reportType == "Истекающие договоры")
            {
                dataGridViewReports.Columns.Add("ContractName", "Договор");
                dataGridViewReports.Columns.Add("Tenant", "Арендатор");
                dataGridViewReports.Columns.Add("WarehouseName", "Склад");
                dataGridViewReports.Columns.Add("ExpirationDate", "Дата истечения");
            }
            else if (reportType == "Платежи арендаторов")
            {
                dataGridViewReports.Columns.Add("Tenant", "Арендатор");
                dataGridViewReports.Columns.Add("WarehouseName", "Склад");
                dataGridViewReports.Columns.Add("PaymentStatus", "Статус оплаты");
                dataGridViewReports.Columns.Add("PaymentDate", "Дата оплаты");
            }
        }

        // Метод для загрузки данных в отчет
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Проверяем выбранный тип отчета
            string reportType = comboBoxReportType.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(reportType))
            {
                MessageBox.Show("Выберите тип отчета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Инициализируем столбцы для выбранного типа отчета
            InitializeDataGridViewColumns(reportType);

            // Очистка строк в таблице
            dataGridViewReports.Rows.Clear();

            // Добавление данных в зависимости от типа отчета
            if (reportType == "Сводка по складам")
            {
                dataGridViewReports.Rows.Add("Склад 1", "Продукты", "500 м²", "100 м² свободно");
                dataGridViewReports.Rows.Add("Склад 2", "Строительные материалы", "1000 м²", "300 м² свободно");
            }
            else if (reportType == "Сводка по ТМЦ")
            {
                dataGridViewReports.Rows.Add("Товар 1", "Склад 1", "Арендатор 1", "50 шт.");
                dataGridViewReports.Rows.Add("Товар 2", "Склад 2", "Арендатор 2", "100 шт.");
            }
            else if (reportType == "Истекающие договоры")
            {
                dataGridViewReports.Rows.Add("Договор 1", "Арендатор 1", "Склад 1", "31.12.2024");
                dataGridViewReports.Rows.Add("Договор 2", "Арендатор 2", "Склад 2", "15.01.2025");
            }
            else if (reportType == "Платежи арендаторов")
            {
                dataGridViewReports.Rows.Add("Арендатор 1", "Склад 1", "Оплачено", "01.12.2024");
                dataGridViewReports.Rows.Add("Арендатор 2", "Склад 2", "Не оплачено", "15.11.2024");
            }
        }
    }
}
