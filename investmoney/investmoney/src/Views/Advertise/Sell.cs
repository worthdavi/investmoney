using investmoney.src.Controllers;
using investmoney.src.DAO;
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
    public partial class Sell : Form
    {
        public Home previousScreen = new Home();
        WalletController walletController = new WalletController();
        public int limitAmount = 0;
        public Sell(Home previousScreen)
        {
            InitializeComponent();
            cBoxActives.Items.Add("None");
            cBoxActives.SelectedIndex = 0;
            List<String> items = walletController.GetActivesByUserId(LoginInfo.UserId);
            for (int i = 0; i < items.Count; i++)
            {
                cBoxActives.Items.Add(items[i]);
            }
            this.previousScreen.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.previousScreen.Enabled = true;
            this.Close();
        }

        private void cBoxActives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxActives.SelectedIndex > 0)
            {
                lblAmount.Visible = true;
                txtAmount.Visible = true;
                lblLimit.Text = "/" + Convert.ToString(walletController.GetActivesAmountByTickerId(LoginInfo.UserId, cBoxActives.Text));
                this.limitAmount = walletController.GetActivesAmountByTickerId(LoginInfo.UserId, cBoxActives.Text);
                lblLimit.Visible = true;
            }
            else
            {
                lblAmount.Visible = false;
                txtAmount.Visible = false;
                txtPrice.Visible = false;
                lblPrice.Visible = false;
                btnConfirm.Visible = false;
                lblInfo.Visible = false;
                lblLimit.Visible = false;
                lblInfo.Text = "You are going to sell {0} {1} actions for R$ {2}.";
            }
           
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            lblInfo.Text = String.Format("You are going to sell {0} {1} actions for R$ {2}.", txtAmount.Text, cBoxActives.Text, txtPrice.Text);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPrice.TextLength > 0)
            {
                if (!btnConfirm.Visible || !lblInfo.Visible)
                {
                    btnConfirm.Visible = true;
                    lblInfo.Visible = true;
                }
            }
            else if (txtPrice.TextLength == 0 && (lblInfo.Visible || btnConfirm.Visible))
            {
                btnConfirm.Visible = false;
                lblInfo.Visible = false;
                lblInfo.Text = "You are going to sell {0} {1} actions for R$ {2}.";
            }
            lblInfo.Text = String.Format("You are going to sell {0} {1} actions for R$ {2}.", txtAmount.Text, cBoxActives.Text, txtPrice.Text);
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtAmount.TextLength > 0 && !txtPrice.Visible)
            {
                txtPrice.Visible = true;
                lblPrice.Visible = true;
            }
            else if(txtAmount.TextLength == 0 && txtPrice.Visible)
            {
                txtPrice.Visible = false;
                lblPrice.Visible = false;
                btnConfirm.Visible = false;
                lblInfo.Visible = false;
                lblInfo.Text = "You are going to sell {0} {1} actions for R$ {2}.";
            }
            lblInfo.Text = String.Format("You are going to sell {0} {1} actions for R$ {2},00.", txtAmount.Text, cBoxActives.Text, txtPrice.Text);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtAmount.Text);
            int price = Convert.ToInt32(txtPrice.Text);
            int wallet_id = 1;
            if (amount > this.limitAmount)
            {
                MessageBox.Show("You do not have enough actions. Your " + cBoxActives.Text + " actives amount is " + this.limitAmount);
                return;
            }
            AdvertiseController controller = new AdvertiseController();
            controller.CreateOffer(amount, price, 0, wallet_id, cBoxActives.Text);
            walletController.SetActivesAmountByTickerId(LoginInfo.UserId, cBoxActives.Text, amount);
            MessageBox.Show("You succesfully created an offer. Details:\n" +
                "You are now selling " + amount + " of " + cBoxActives.Text + " actives for R$" + price + ",00 each! :)");
            this.previousScreen.Enabled = true;
            this.Close();
        }
    }
}
