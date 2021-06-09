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
using wallstreet.src.Views.Admin;

namespace wallstreet.src.Views
{
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
            LoginInfo.GlobalUser = SQLiteControl.LoadUserById(LoginInfo.UserId);
            this.Text = String.Format(this.Text,  LoginInfo.GlobalUser.Username);
            if (LoginInfo.GlobalUser.Type == 1)
            {
                lblPainelAdministrativo.Visible = true;
                lblPainelAdministrativo.Enabled = true;
            }
        }

        private void lblPainelAdministrativo_Click(object sender, EventArgs e)
        {
            Admin.Admin admin = new Admin.Admin();
            admin.Show();
            this.Hide();
        }
    }
}
