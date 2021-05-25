
namespace wallstreet
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLoginSubmit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("LEMON MILK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(660, 318);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(754, 317);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(117, 20);
            this.txtLoginUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("LEMON MILK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(660, 351);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(754, 350);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(117, 20);
            this.txtLoginPassword.TabIndex = 3;
            // 
            // btnLoginSubmit
            // 
            this.btnLoginSubmit.Location = new System.Drawing.Point(775, 415);
            this.btnLoginSubmit.Name = "btnLoginSubmit";
            this.btnLoginSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnLoginSubmit.TabIndex = 4;
            this.btnLoginSubmit.Text = "Submit";
            this.btnLoginSubmit.UseVisualStyleBackColor = true;
            this.btnLoginSubmit.Click += new System.EventHandler(this.btnLoginSubmit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(662, 379);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(46, 12);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Error label";
            this.lblError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLoginSubmit);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtLoginUsername);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLoginSubmit;
        public System.Windows.Forms.Label lblError;
    }
}

