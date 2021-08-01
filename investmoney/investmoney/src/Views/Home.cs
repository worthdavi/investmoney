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
using investmoney.src.Views.Admin;

namespace investmoney.src.Views
{
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
            LoginInfo.GlobalUser = SQLiteControl.LoadUserById(LoginInfo.UserId);
            this.Text = String.Format(this.Text,  LoginInfo.GlobalUser.Username);
            double accountBalance = Convert.ToInt32(LoginInfo.GlobalUser.Balance);
            this.lblAccountBalance.Text = String.Format("Your account balance is: {0:C}", accountBalance);
            WalletController walletController = new WalletController();
            dataTableActives.DataSource = walletController.LoadUserWallet(LoginInfo.UserId);
            dataTableActives.Columns["unity"].DefaultCellStyle.Format = "C";
            if (LoginInfo.GlobalUser.Type == 1)
            {
                lblPainelAdministrativo.Visible = true;
                lblPainelAdministrativo.Enabled = true;
            }
        }

        private void lblPainelAdministrativo_Click(object sender, EventArgs e)
        {
            Admin.Admin admin = new Admin.Admin();
            admin.Show();
            this.Hide();
        }
    }
}
