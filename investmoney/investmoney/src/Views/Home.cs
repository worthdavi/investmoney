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
            for(int i = 0; i < dataTableHistory.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataTableHistory.Rows[i].Cells["price"].Value) < 0)
                {
                    dataTableHistory.Rows[i].Cells["price"].Style.BackColor = Color.Red;
                }
                else
                {
                    dataTableHistory.Rows[i].Cells["price"].Style.BackColor = Color.LightGreen;
                }
            }
            if (LoginInfo.GlobalUser.Type == 1)
            {
                btnPainelAdministrativo.Visible = true;
                btnPainelAdministrativo.Enabled = true;
            }
        }
        public static DateTime UnixTimeStampToDateTime(float unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
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
    }
}
