﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wzrehouse
{
    public partial class ContractsForm : Form
    {
        // Список для хранения данных о договорах
        private List<Contract> contractsList = new List<Contract>();

        public ContractsForm()
        {
            InitializeComponent();
        }

        // Обновление таблицы DataGridView
        private void UpdateTable()
        {
            dataGridViewContracts.Rows.Clear();
            foreach (var contract in contractsList)
            {
                dataGridViewContracts.Rows.Add(
                    contract.ContractNumber,
                    contract.TenantName,
                    contract.Warehouse,
                    contract.StartDate.ToShortDateString(),
                    contract.EndDate.ToShortDateString(),
                    contract.IsPaid ? "Оплачено" : "Не оплачено"
                );
            }
        }

        // Добавление нового договора
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContractNumber.Text) ||
                string.IsNullOrWhiteSpace(txtTenantName.Text) ||
                string.IsNullOrWhiteSpace(txtWarehouse.Text))
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание нового договора
            Contract contract = new Contract
            {
                ContractNumber = txtContractNumber.Text,
                TenantName = txtTenantName.Text,
                Warehouse = txtWarehouse.Text,
                StartDate = dateTimePickerStart.Value,
                EndDate = dateTimePickerEnd.Value,
                IsPaid = checkBoxIsPaid.Checked
            };

            contractsList.Add(contract);
            UpdateTable();
            ClearInputs();
        }

        // Удаление договора
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewContracts.SelectedRows.Count > 0)
            {
                int index = dataGridViewContracts.SelectedRows[0].Index;
                contractsList.RemoveAt(index);
                UpdateTable();
            }
            else
            {
                MessageBox.Show("Выберите договор для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Очистка полей ввода
        private void ClearInputs()
        {
            txtContractNumber.Clear();
            txtTenantName.Clear();
            txtWarehouse.Clear();
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now.AddMonths(1);
            checkBoxIsPaid.Checked = false;
        }
    }

    // Класс для описания договора
    public class Contract
    {
        public string ContractNumber { get; set; }
        public string TenantName { get; set; }
        public string Warehouse { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
