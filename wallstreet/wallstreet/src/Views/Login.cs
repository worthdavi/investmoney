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

            bool loggedIn = src.DAO.Auth.Login(username, password);

            if (loggedIn)
            {
                Home home = new Home();
                home.Show();
                this.Hide();                
            }else{
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "Usuário ou senha incorretos.";
                lblLostPassword.Visible = true;
            }

        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLoginSubmit.PerformClick();
        }

        private void lblLostPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fale com um administrador para que o mesmo recupere sua senha.");
        }
    }
}
