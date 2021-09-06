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
            dataTableActives.DataSource = walletController.LoadUserWallet(LoginInfo.UserId);
            for (int i = 0; i < dataTableActives.Rows.Count; i++)
            {
                long timestamp = Convert.ToInt64(dataTableActives.Rows[i].Cells["boughtdate"].Value.ToString());
                var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Math.Round(timestamp / 1000d)).ToLocalTime();
                string dT = @"dd/MM/yyyy, hh/mm/ss";
                //Convert.ToDateTime(dataTableActives.Rows[i].Cells["boughtdate"].Value.ToString());
                //dataTableActives.Rows[i].Cells["boughtdate"].Value = dateTime.ToString(dT);
            }
            dataTableActives.Columns["unity"].DefaultCellStyle.Format = "C";
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
            Buy_new buyScreen = new Buy_new(this);
            buyScreen.Show();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            reloadInfo();
        }
    }
}
