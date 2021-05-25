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
                lblError.Text = "Por favor, insira u usuário e senha.";
                return;
            }
            bool loggedIn = SQLiteControl.TryLogin(username, password);
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
    }
}
