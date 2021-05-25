using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wallstreet.src.Views
{
    public partial class Home : Form
    {
        
        public Home()
        {       
            InitializeComponent();         
        }

        // public User user = new User();

        /* type = 1 significa que o usuário eh adm e libera o botão pra ele
        if (user.Type == 1)
        {
            lblPainelAdministrativo.Visible = true;
        }
        */

        private void lblPainelAdministrativo_Click(object sender, EventArgs e)
        {
            this.Hide();
            // abre painel administrativo
        }
    }
}
