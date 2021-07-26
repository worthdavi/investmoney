using System;
using System.Collections.Generic;
using System.Windows.Forms;
using wallstreet.src.Controllers;

namespace wallstreet.src.Views.Admin.Users
{
    public partial class UserRegister : Form
    {

        public Admin previousScreen = new Admin();

        public UserRegister(Admin previousScreen)
        {
            InitializeComponent();
            this.previousScreen = previousScreen;
            this.previousScreen.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.previousScreen.Enabled = true;
            this.Hide();
        }

        private List<Label> GetLabelList()
        {
            List<Label> Labels = new List<Label>();
            Labels.Add(this.lblTypeError);
            Labels.Add(this.lblBalanceError);
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
            Boxes.Add(this.txtType);
            Boxes.Add(this.txtBalance);
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
                lblUsernameError.Text = "This username is already in use.";
            }

            if (userController.IsEmailRepeated(txtEmail.Text))
            {
                alright = false;
                lblEmailError.Visible = true;
                lblEmailError.Text = "This e-mail is already in use.";
            }

            if ((Convert.ToInt32(txtType.Text) != 0) && (Convert.ToInt32(txtType.Text) != 1))
            {
                alright = false;
                lblTypeError.Visible = true;
                lblTypeError.Text = "Type must be 1 (admin) or 0 (common user).";
            }

            if (Convert.ToInt32(txtBalance.Text) <= 0)
            {
                alright = false;
                lblBalanceError.Visible = true;
                lblBalanceError.Text = "Balance value must be higher than 0.";
            }

            if (!alright)
            {
                return;
            }
            String user = userController.create(txtUsername.Text, txtEmail.Text, txtPassword.Text, txtType.Text, txtBalance.Text);
            if (user == txtUsername.Text)
            {
                MessageBox.Show("You succesfully created the user " + user.ToUpper());
                this.previousScreen.Enabled = true;
                this.Hide();
            }
            if (user == "false")
            {
                MessageBox.Show("fail to create user ");
                this.previousScreen.Enabled = true;
                this.Hide();
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
