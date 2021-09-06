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
    public partial class Buy_new : Form
    {
        public Home previousScreen = new Home();
        WalletController walletController = new WalletController();
        ActiveController activeController = new ActiveController();
        AdvertiseController advertiseController = new AdvertiseController();
        public double result;
        public Buy_new(Home previousScreen)
        {
            InitializeComponent();
            cBoxActives.Items.Add("None");
            cBoxActives.SelectedIndex = 0;
            List<String> items = activeController.GetActivesNames();
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
            if (cBoxActives.SelectedIndex > 0)
            {
                lblAmount.Visible = true;
                txtAmount.Visible = true;
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
                lblInfo.Text = "You are going to buy {0} {1} actions for R$ {2}.";
            }

        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            lblInfo.Text = String.Format("You are going to buy {0} {1} actions for R$ {2}.", txtAmount.Text, cBoxActives.Text, txtPrice.Text);
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtAmount.TextLength > 0)
            {
                txtPrice.Visible = true;
                double price = activeController.GetActivePriceByTickerId(cBoxActives.Text);
                result = Convert.ToInt32(txtAmount.Text) * price;
                txtPrice.Text = Convert.ToString(result);
                lblPrice.Visible = true;
                lblInfo.Visible = true;
                btnConfirm.Visible = true;
            }
            else if (txtAmount.TextLength == 0 && txtPrice.Visible)
            {
                txtPrice.Visible = false;
                lblPrice.Visible = false;
                btnConfirm.Visible = false;
                lblInfo.Visible = false;
                lblInfo.Text = "You are going to buy {0} {1} actions for R$ {2}.";
            }
            lblInfo.Text = String.Format("You are going to buy {0} {1} actions for R$ {2},00.", txtAmount.Text, cBoxActives.Text, txtPrice.Text);
        }
        public String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ActiveModel active = new ActiveModel();
            active = activeController.GetActiveByTicker(cBoxActives.Text);
            int amount = Convert.ToInt32(txtAmount.Text);
            long Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            advertiseController.AcceptOffer(active, amount, LoginInfo.GlobalUser, amount, result, Timestamp);
            MessageBox.Show("You succesfully bought some active. Details:\n" +
              "You just bought " + amount + " of " + cBoxActives.Text + " actives for R$" + active.price + ",00 each! :)");
            this.previousScreen.Enabled = true;
            this.Close();
        }
    }
}
