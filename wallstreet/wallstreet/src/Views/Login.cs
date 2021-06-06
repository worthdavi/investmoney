using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wallstreet.src.Views;

namespace wallstreet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;
            if (username == "" || password == "")
            {
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "Por favor, insira usuário e senha.";
                return;
            }
            //bool loggedIn1 = SQLiteControl.TryLogin(username, password);
            bool loggedIn = src.DAO.Auth.Login(username, password);
           // Login
            if (loggedIn)
            {
                // tem q passar o usuário pra a tela de home
                Home home = new Home();
                home.Show();
                this.Hide();                
            }else{
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "Usuário ou senha incorretos.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
