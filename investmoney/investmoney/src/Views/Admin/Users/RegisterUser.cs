using investmoney.src.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace investmoney.src.Views.Admin.Users
{
    public partial class RegisterUser : Form
    {
        public Admin previousScreen = new Admin();
        public RegisterUser(Admin previousScreen)
        {
            InitializeComponent();
            this.cBoxType.SelectedIndex = 0;
            this.previousScreen = previousScreen;
            this.previousScreen.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.previousScreen.Enabled = true;
            this.Close();
        }

        private List<Label> GetLabelList()
        {
            List<Label> Labels = new List<Label>();
            Labels.Add(this.lblEmailError);
            Labels.Add(this.lblPasswordError);
            Labels.Add(this.lblUsernameError);
            return Labels;
        }

        private List<TextBox> GetTxtList()
        {
            List<TextBox> Boxes = new List<TextBox>();
            Boxes.Add(this.txtUsername);
            Boxes.Add(this.txtEmail);
            Boxes.Add(this.txtPassword);
            return Boxes;
        }

        private void ResetLabels(List<Label> Labels)
        {
            foreach (Label label in Labels)
            {
                label.Visible = false;
            }
        }

        private bool hasEmptyBoxes(List<TextBox> Boxes)
        {
            bool ret = false;
            foreach (TextBox box in Boxes)
            {
                if (box.Text.Length == 0)
                {
                    ret = true;
                }

            }
            return ret;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            List<TextBox> Boxes = GetTxtList();
            List<Label> Labels = GetLabelList();
            ResetLabels(Labels);
            UserController userController = new UserController();
            if (hasEmptyBoxes(Boxes))
            {
                MessageBox.Show("Please, fill all fields.");
                return;
            }

            bool alright = true;

            if (userController.IsUsernameRepeated(txtUsername.Text))
            {
                alright = false;
                lblUsernameError.Visible = true;
                lblUsernameError.Text = "Username is already in use.";
            }

            if (userController.IsEmailRepeated(txtEmail.Text))
            {
                alright = false;
                lblEmailError.Visible = true;
                lblEmailError.Text = "E-mail is already in use.";
            }

            if (!alright)
            {
                return;
            }
            String user = userController.create(txtUsername.Text, txtEmail.Text, txtPassword.Text, cBoxType.SelectedIndex);
            if (user == txtUsername.Text)
            {
                MessageBox.Show("You succesfully created the user " + user.ToUpper());
                this.previousScreen.Enabled = true;
                this.Close();
            }
            if (user == "false")
            {
                MessageBox.Show("Failed to create the user.");
            }
        }

        private void txtRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnConfirm.PerformClick();
        }

        private void txtRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
