
namespace wallstreet.src.Views.Admin
{
    partial class Admin
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
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.lblRegisterUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteActive = new System.Windows.Forms.Button();
            this.lblRegisterActive = new System.Windows.Forms.Label();
            this.btnRegisterActive = new System.Windows.Forms.Button();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.btnEditActive = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Location = new System.Drawing.Point(35, 63);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterUser.TabIndex = 0;
            this.btnRegisterUser.Text = "Register";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // lblRegisterUser
            // 
            this.lblRegisterUser.AutoSize = true;
            this.lblRegisterUser.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterUser.Location = new System.Drawing.Point(63, 24);
            this.lblRegisterUser.Name = "lblRegisterUser";
            this.lblRegisterUser.Size = new System.Drawing.Size(179, 18);
            this.lblRegisterUser.TabIndex = 1;
            this.lblRegisterUser.Text = "Users Management Panel";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEditUser);
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.lblRegisterUser);
            this.panel1.Controls.Add(this.btnRegisterUser);
            this.panel1.Location = new System.Drawing.Point(12, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 125);
            this.panel1.TabIndex = 2;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(208, 63);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEditActive);
            this.panel2.Controls.Add(this.btnDeleteActive);
            this.panel2.Controls.Add(this.lblRegisterActive);
            this.panel2.Controls.Add(this.btnRegisterActive);
            this.panel2.Location = new System.Drawing.Point(461, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 125);
            this.panel2.TabIndex = 3;
            // 
            // btnDeleteActive
            // 
            this.btnDeleteActive.Location = new System.Drawing.Point(211, 63);
            this.btnDeleteActive.Name = "btnDeleteActive";
            this.btnDeleteActive.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteActive.TabIndex = 1;
            this.btnDeleteActive.Text = "Delete";
            this.btnDeleteActive.UseVisualStyleBackColor = true;
            // 
            // lblRegisterActive
            // 
            this.lblRegisterActive.AutoSize = true;
            this.lblRegisterActive.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterActive.Location = new System.Drawing.Point(70, 24);
            this.lblRegisterActive.Name = "lblRegisterActive";
            this.lblRegisterActive.Size = new System.Drawing.Size(189, 18);
            this.lblRegisterActive.TabIndex = 1;
            this.lblRegisterActive.Text = "Actives Management Panel";
            // 
            // btnRegisterActive
            // 
            this.btnRegisterActive.Location = new System.Drawing.Point(37, 63);
            this.btnRegisterActive.Name = "btnRegisterActive";
            this.btnRegisterActive.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterActive.TabIndex = 0;
            this.btnRegisterActive.Text = "Register";
            this.btnRegisterActive.UseVisualStyleBackColor = true;
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.Location = new System.Drawing.Point(206, 9);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(368, 25);
            this.lblAdminPanel.TabIndex = 4;
            this.lblAdminPanel.Text = "Welcome to the admin panel, {0}";
            // 
            // btnEditActive
            // 
            this.btnEditActive.Location = new System.Drawing.Point(125, 63);
            this.btnEditActive.Name = "btnEditActive";
            this.btnEditActive.Size = new System.Drawing.Size(75, 23);
            this.btnEditActive.TabIndex = 2;
            this.btnEditActive.Text = "Edit";
            this.btnEditActive.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(122, 63);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdminPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Label lblRegisterUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteActive;
        private System.Windows.Forms.Label lblRegisterActive;
        private System.Windows.Forms.Button btnRegisterActive;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnEditActive;
    }
}