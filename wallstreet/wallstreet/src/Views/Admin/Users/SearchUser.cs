using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wallstreet.src.Controllers;
using wallstreet.src.DAO;

namespace wallstreet.src.Views.Admin.Users
{
    public partial class SearchUser : Form
    {
        public Admin previousScreen = new Admin();

        public SearchUser(Admin previousScreen)
        {
            InitializeComponent();
            this.previousScreen = previousScreen;
            this.previousScreen.Enabled = false;
            UserController userController = new UserController();
            UserTable.DataSource = userController.GetAllUsers();
            cBoxSearchBy.SelectedIndex = 0;
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
            if(txtSearchUser.Text.Length == 0)
            {
                return;
            }

            string valueToSearch = txtSearchUser.Text;

            DataGridViewCell cell = SearchInDataGrid(valueToSearch, UserTable, cBoxSearchBy.SelectedIndex);
            if (cell != null)
            {
                //melhorar aqui pra as pesquisas irem pros pprimeiros indexes
                cell.Style = new DataGridViewCellStyle { ForeColor = Color.Red };
            }
        }
    }
}
