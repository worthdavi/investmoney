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
    public partial class Calculate : Form
    {
        public Home previousScreen = new Home();
        public Calculate(Home previousScreen)
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dia = textBox4.Text;
            string mes = textBox2.Text;
            string ano = textBox3.Text;
            
            LoginInfo.GlobalUser = SQLiteControl.LoadUserById(LoginInfo.UserId);
            WalletController walletController = new WalletController();
            TransactionController transactionsController = new TransactionController();

            var wallets = walletController.LoadUserWallet(LoginInfo.UserId);
            this.textBox1.Text = transactionsController.calculateMaked(wallets, LoginInfo.UserId, dia, mes, ano).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dia = textBox4.Text;
            string mes = textBox2.Text;
            string ano = textBox3.Text;

            LoginInfo.GlobalUser = SQLiteControl.LoadUserById(LoginInfo.UserId);
            WalletController walletController = new WalletController();
            TransactionController transactionsController = new TransactionController();

            var wallets = walletController.LoadUserWallet(LoginInfo.UserId);
            this.textBox1.Text = transactionsController.calculateMakedNaoRealizado(wallets, LoginInfo.UserId, dia, mes, ano).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             this.previousScreen.Enabled = true;
             this.Close();
            
        }
    }
}
