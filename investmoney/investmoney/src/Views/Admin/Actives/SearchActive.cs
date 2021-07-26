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

namespace investmoney.src.Views.Admin.Actives
{
    public partial class SearchActive : Form
    {
        public Admin previousScreen = new Admin();

        public SearchActive(Admin previousScreen)
        {
            InitializeComponent();
            this.previousScreen = previousScreen;
            this.previousScreen.Enabled = false;
            ActiveController activeController = new ActiveController();
            ActiveTable.DataSource = activeController.GetActiveList();
           // cBoxSearchBy.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            this.previousScreen.Enabled = true;
            this.Hide();
        }
    }
}
