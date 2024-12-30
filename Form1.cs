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
            InitializeTabs();
        }

        private void InitializeTabs()
        {
            // Создаем TabControl
            TabControl tabControl = new TabControl
            {
                Dock = DockStyle.Fill
            };

            // Создаем вкладки
            TabPage warehouseTab = new TabPage("Склады");
            TabPage goodsTab = new TabPage("Товары");
            TabPage contractTab = new TabPage("Контракты");
            TabPage clientTab = new TabPage("Клиенты");
            TabPage reportsTab = new TabPage("Отчеты");

            // Добавляем формы в каждую вкладку
            warehouseTab.Controls.Add(CreateEmbeddedForm(new WarehousesForm()));
            goodsTab.Controls.Add(CreateEmbeddedForm(new GoodsForm()));
            contractTab.Controls.Add(CreateEmbeddedForm(new ContractsForm()));
            clientTab.Controls.Add(CreateEmbeddedForm(new ClientsForm()));
            reportsTab.Controls.Add(CreateEmbeddedForm(new ReportsForm()));

            // Добавляем вкладки в TabControl
            tabControl.TabPages.Add(warehouseTab);
            tabControl.TabPages.Add(goodsTab);
            tabControl.TabPages.Add(contractTab);
            tabControl.TabPages.Add(clientTab);
            tabControl.TabPages.Add(reportsTab);

            // Добавляем TabControl в MainForm
            this.Controls.Add(tabControl);
        }

        // Метод для внедрения формы в TabPage
        private Control CreateEmbeddedForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            return form;
        }
    }
}
