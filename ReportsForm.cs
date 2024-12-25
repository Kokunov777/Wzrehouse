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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        // Метод для загрузки данных в отчет
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Очистка таблицы
            dataGridViewReports.Rows.Clear();

            // Пример данных для отчета
            string reportType = comboBoxReportType.SelectedItem?.ToString();

            if (reportType == "Сводка по складам")
            {
                // Добавить пример отчета по складам
                dataGridViewReports.Rows.Add("Склад 1", "Продукты", "500 м²", "100 м² свободно");
                dataGridViewReports.Rows.Add("Склад 2", "Строительные материалы", "1000 м²", "300 м² свободно");
            }
            else if (reportType == "Сводка по ТМЦ")
            {
                // Добавить пример отчета по ТМЦ
                dataGridViewReports.Rows.Add("Товар 1", "Склад 1", "Арендатор 1", "50 шт.");
                dataGridViewReports.Rows.Add("Товар 2", "Склад 2", "Арендатор 2", "100 шт.");
            }
            else if (reportType == "Истекающие договоры")
            {
                // Добавить пример отчета по договорам
                dataGridViewReports.Rows.Add("Договор 1", "Арендатор 1", "Склад 1", "31.12.2024");
                dataGridViewReports.Rows.Add("Договор 2", "Арендатор 2", "Склад 2", "15.01.2025");
            }
            else if (reportType == "Платежи арендаторов")
            {
                // Добавить пример отчета по платежам
                dataGridViewReports.Rows.Add("Арендатор 1", "Склад 1", "Оплачено", "01.12.2024");
                dataGridViewReports.Rows.Add("Арендатор 2", "Склад 2", "Не оплачено", "15.11.2024");
            }
            else
            {
                MessageBox.Show("Выберите тип отчета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

