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
using investmoney.src.DAO;

namespace investmoney.src.Views.Admin.Users
{
    public partial class SearchUser : Form
    {
        public Admin previousScreen = new Admin();
        UserController userController = new UserController();
        public void reloadInfo()
        {           
            UserTable.DataSource = userController.GetAllUsers();
            UserTable.Columns["id"].ReadOnly = true;
            cBoxSearchBy.SelectedIndex = 0;
        }

        public SearchUser(Admin previousScreen)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < UserTable.Rows.Count; i++)
            {
                // ticker, amount, price, description
                User user = new User();
                user.setId(Convert.ToInt32(UserTable.Rows[i].Cells["id"].Value));
                user.Username = UserTable.Rows[i].Cells["Username"].Value.ToString();
                user.Email = UserTable.Rows[i].Cells["Email"].Value.ToString();
                user.Password = UserTable.Rows[i].Cells["Password"].Value.ToString();
                user.Type = Convert.ToInt32(UserTable.Rows[i].Cells["Type"].Value);
                userController.SaveUser(user);
            }
        }

        private void SearchUser_Load(object sender, EventArgs e)
        {
            reloadInfo();
        }
    }
}
