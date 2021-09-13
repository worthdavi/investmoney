using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using investmoney.src.Controllers;
using investmoney.src.Models;

namespace investmoney.src.Views.Admin.Actives
{
    public partial class SearchActive : Form
    {
        public Admin previousScreen = new Admin();
        ActiveController activeController = new ActiveController();

        public void reloadInfo()
        {
            ActiveTable.DataSource = activeController.GetActiveList();
            cBoxSearchBy.SelectedIndex = 0;
        }

        public SearchActive(Admin previousScreen)
        {
            InitializeComponent();
            this.previousScreen = previousScreen;
            this.previousScreen.Enabled = false;          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.previousScreen.Enabled = true;
            this.Hide();
        }

        private DataGridViewCell SearchInDataGrid(string searchText, DataGridView dataGridView, int columnIndex)
        {
            DataGridViewCell foundText = null;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnIndex].Value != null && searchText == row.Cells[columnIndex].Value.ToString())
                {
                    foundText = row.Cells[columnIndex];
                    break;
                }
            }

            return foundText;
        }

        private void imgSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchActive.Text.Length == 0)
            {
                return;
            }

            string valueToSearch = txtSearchActive.Text;

            DataGridViewCell cell = SearchInDataGrid(valueToSearch, ActiveTable, cBoxSearchBy.SelectedIndex);
            if (cell != null)
            {
                cell.Style = new DataGridViewCellStyle { ForeColor = Color.Red };
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ActiveTable.Rows.Count; i++)
            {
                // ticker, amount, price, description
                ActiveModel active = new ActiveModel();
                active.ticker = ActiveTable.Rows[i].Cells["ticker"].Value.ToString();
                active.amount = Convert.ToInt32(ActiveTable.Rows[i].Cells["amount"].Value);
                active.price = Convert.ToDecimal(ActiveTable.Rows[i].Cells["price"].Value);
                active.description = ActiveTable.Rows[i].Cells["description"].Value.ToString();
                activeController.SaveActive(active);
            }
        }

        private void SearchActive_Activated(object sender, EventArgs e)
        {
            reloadInfo();
        }
    }
}
