using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wallstreet.src.DAO;
using wallstreet.src.Views;
using wallstreet.src.Views.Admin.Users;

namespace wallstreet.src.Views.Admin
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
            UserRegister screen = new UserRegister(this);
            screen.Show();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            SearchUser screen = new SearchUser(this);
            screen.Show();
        }
    }
}
