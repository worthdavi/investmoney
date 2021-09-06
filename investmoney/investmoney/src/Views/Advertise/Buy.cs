using investmoney.src.Controllers;
using investmoney.src.DAO;
using investmoney.src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace investmoney.src.Views.Advertise
{
    public partial class Buy : Form
    {
        public Home previousScreen = new Home();
        WalletController walletController = new WalletController();
        AdvertiseController advertiseController = new AdvertiseController();
        double accountBalance;
        public void reloadOffers()
        {
            accountBalance = LoginInfo.GlobalUser.Balance;
            this.dataTableActives.DataSource = advertiseController.LoadOffers();
            this.dataTableActives.Columns["price"].DefaultCellStyle.Format = "C";
            this.lblBalance.Text = "Your balance is: " + accountBalance + ",00 R$";
        }
        public Buy(Home previousScreen)
        {
            InitializeComponent();
            reloadOffers();
        }

        private void txtNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.previousScreen.Enabled = true;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (txtOfferId.Text.Length <= 0)
            {
                lblOffer.ForeColor = Color.Red;
                lblOfferError.Text = "Invalid offer!";
                lblOfferError.Visible = true;
                return;
            }

            AdvertiseModel model = new AdvertiseModel();
            model = advertiseController.GetOfferById(Convert.ToInt32(txtOfferId.Text));

            if (!model.GetType().GetProperties().Any())
            {
                lblOffer.ForeColor = Color.Red;
                lblOfferError.Text = "Invalid offer!";
                lblOfferError.Visible = true;
                return;
            }

            if (txtAmount.Text.Length <= 0)
            {
                lblAmount.ForeColor = Color.Red;
                lblAmountError.Text = "Invalid amount!";
                lblAmountError.Visible = true;
                return;
            }

            int amountBeingBought = Convert.ToInt32(txtAmount.Text);
            int totalValue = amountBeingBought * model.price;
            if(totalValue > Convert.ToDouble(LoginInfo.GlobalUser.Balance))
            {
                lblAmount.ForeColor = Color.Red;
                lblAmountError.Text = "Not enough money!";
                lblAmountError.Visible = true;
                return;
            }

           
            advertiseController.AcceptOffer(model, LoginInfo.GlobalUser, amountBeingBought, totalValue);
            reloadOffers();

        }

        private void txtOfferId_KeyDown(object sender, KeyEventArgs e)
        {
            if(lblOffer.ForeColor == Color.Red)
            {
                lblOffer.ForeColor = Color.Black;
                lblOfferError.Text = "";
                lblOfferError.Visible = false;
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (lblAmount.ForeColor == Color.Red)
            {
                lblAmount.ForeColor = Color.Black;
                lblAmountError.Text = "";
                lblAmountError.Visible = false;
            }
        }
    }
}
