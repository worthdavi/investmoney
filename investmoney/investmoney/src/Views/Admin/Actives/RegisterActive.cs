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

namespace investmoney.src.Views.Admin.ativos
{
    public partial class RegisterActive : Form
    {
        public Admin previousScreen = new Admin();       
        public RegisterActive(Admin previousScreen)
        {
            InitializeComponent();
            this.previousScreen = previousScreen;
            this.previousScreen.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            previousScreen.Enabled = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveController activeController = new ActiveController();
            int result = activeController.Register(textBox1.Text, maskedTextBox1.Text, textBox3.Text, textBox4.Text);
            if (result == 1) Console.WriteLine("deu certo");
            else Console.WriteLine("deu erro");
        }
    }
}
