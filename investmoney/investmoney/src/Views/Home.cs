using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using investmoney.src.Controllers;
using investmoney.src.DAO;
using investmoney.src.Views.Admin;
using investmoney.src.Views.Advertise;

namespace investmoney.src.Views
{
    public partial class Home : Form
    {
        public DataGridViewColumn CreateColumn(string header, string name)
        {
            DataGridViewColumn newCol = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;
            newCol.HeaderText = header;
            newCol.Name = name;
            return newCol;
        }
        public void reloadInfo()
        {
            LoginInfo.GlobalUser = SQLiteControl.LoadUserById(LoginInfo.UserId);
            this.Text = String.Format(this.Text, LoginInfo.GlobalUser.Username);
            WalletController walletController = new WalletController();
            TransactionController transactionsController = new TransactionController();
            dataTableActives.DataSource = walletController.LoadUserWallet(LoginInfo.UserId);
            dataTableHistory.DataSource = transactionsController.LoadUserTransactions(LoginInfo.GlobalUser);
            dataTableActives.Columns["unity"].DefaultCellStyle.Format = "C";
            dataTableHistory.Columns["price"].DefaultCellStyle.Format = "C";
            //Creating the custom table "type"
            //DataGridViewColumn typeColumn = CreateColumn("type", "type");
            //dataTableHistory.Columns.Add(typeColumn);
            // transactionsController.calculateMaked();
            for (int i = 0; i < dataTableHistory.Rows.Count; i++)
            {
                double price = Convert.ToDouble(dataTableHistory.Rows[i].Cells["price"].Value);
                int amount = Convert.ToInt32(dataTableHistory.Rows[i].Cells["amount"].Value);
                dataTableHistory.Rows[i].Cells["totalcost"].Value = price * amount;
                if (price < 0)
                {
                    // dataTableHistory.Rows[i].Cells["type"].Value = "C";
                    dataTableHistory.Rows[i].Cells["price"].Style.BackColor = Color.Red;
                    dataTableHistory.Rows[i].Cells["totalcost"].Style.BackColor = Color.Red;
                }
                else
                {
                    // dataTableHistory.Rows[i].Cells["type"].Value = "V";
                    dataTableHistory.Rows[i].Cells["price"].Style.BackColor = Color.LightGreen;
                    dataTableHistory.Rows[i].Cells["totalcost"].Style.BackColor = Color.LightGreen;
                }
            }
            if (LoginInfo.GlobalUser.Type == 1)
            {
                btnPainelAdministrativo.Visible = true;
                btnPainelAdministrativo.Enabled = true;
            }
        }

        public Home()
        {
            InitializeComponent();
            reloadInfo();
        }

        private void btnPainelAdministrativo_Click(object sender, EventArgs e)
        {
            Admin.Admin admin = new Admin.Admin();
            admin.Show();
            this.Hide();

           // Advertise.Calculate admin = new Advertise.Calculate();
            // admin.Show();
            // this.Hide();
        }

        private void btnSellActives_Click(object sender, EventArgs e)
        {
            Sell sellScreen = new Sell(this);
            sellScreen.Show();
        }

        private void btnBuyActives_Click(object sender, EventArgs e)
        {
            Buy buyScreen = new Buy(this);
            buyScreen.Show();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            reloadInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Advertise.Calculate admin = new Advertise.Calculate(this);
            admin.Show();
            //this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Advertise.Calculate admin = new Advertise.Calculate(this);
            admin.Show();
           //this.Hide();
        }

       
    }
}
