using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using investmoney.src.DAO;
using investmoney.src.Views;
using investmoney.src.Views.Admin.Users;
using investmoney.src.Views.Admin.ativos;
using investmoney.src.Views.Admin.Actives;

namespace investmoney.src.Views.Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoginInfo.GlobalUser = SQLiteControl.LoadUserById(LoginInfo.UserId);
            lblAdminPanel.Text = String.Format(lblAdminPanel.Text, LoginInfo.GlobalUser.Username);
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            RegisterUser screen = new RegisterUser(this);
            screen.Show();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            SearchUser screen = new SearchUser(this);
            screen.Show();
        }

        private void btnRegisterActive_Click(object sender, EventArgs e)
        {
            RegisterActive registerActive = new RegisterActive(this);
            registerActive.Show();
        }

        private void btnSearchActive_Click(object sender, EventArgs e)
        {
            SearchActive screen = new SearchActive(this);
            screen.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
