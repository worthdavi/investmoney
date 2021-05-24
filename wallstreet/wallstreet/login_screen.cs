using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wallstreet
{
    public partial class login_screen : Form
    {
        public login_screen()
        {
            InitializeComponent();
        }

        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            string user = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;
            if (user == "" || password == "")
            {
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "Por favor, insira u usuário e senha.";
                return;
            }
            bool loggedIn = SQLiteControl.TryLogin(user, password);
            if (loggedIn)
            {
                this.Close();
                //Form home = new Form();
                //home.Show();
            }
            else{
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "Usuário ou senha incorretos.";
            }
        }
    }
}
