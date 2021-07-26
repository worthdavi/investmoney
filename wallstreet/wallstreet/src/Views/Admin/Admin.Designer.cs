
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
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchActive = new System.Windows.Forms.Button();
            this.lblRegisterActive = new System.Windows.Forms.Label();
            this.btnRegisterActive = new System.Windows.Forms.Button();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Location = new System.Drawing.Point(88, 78);
            this.btnRegisterUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(100, 28);
            this.btnRegisterUser.TabIndex = 0;
            this.btnRegisterUser.Text = "Register";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // lblRegisterUser
            // 
            this.lblRegisterUser.AutoSize = true;
            this.lblRegisterUser.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterUser.Location = new System.Drawing.Point(84, 30);
            this.lblRegisterUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterUser.Name = "lblRegisterUser";
            this.lblRegisterUser.Size = new System.Drawing.Size(226, 23);
            this.lblRegisterUser.TabIndex = 1;
            this.lblRegisterUser.Text = "Users Management Panel";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearchUser);
            this.panel1.Controls.Add(this.lblRegisterUser);
            this.panel1.Controls.Add(this.btnRegisterUser);
            this.panel1.Location = new System.Drawing.Point(16, 385);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 153);
            this.panel1.TabIndex = 2;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(223, 78);
            this.btnSearchUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(100, 28);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSearchActive);
            this.panel2.Controls.Add(this.lblRegisterActive);
            this.panel2.Controls.Add(this.btnRegisterActive);
            this.panel2.Location = new System.Drawing.Point(615, 385);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 153);
            this.panel2.TabIndex = 3;
            // 
            // btnSearchActive
            // 
            this.btnSearchActive.Location = new System.Drawing.Point(245, 78);
            this.btnSearchActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchActive.Name = "btnSearchActive";
            this.btnSearchActive.Size = new System.Drawing.Size(100, 28);
            this.btnSearchActive.TabIndex = 2;
            this.btnSearchActive.Text = "Search";
            this.btnSearchActive.UseVisualStyleBackColor = true;
            // 
            // lblRegisterActive
            // 
            this.lblRegisterActive.AutoSize = true;
            this.lblRegisterActive.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterActive.Location = new System.Drawing.Point(93, 30);
            this.lblRegisterActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterActive.Name = "lblRegisterActive";
            this.lblRegisterActive.Size = new System.Drawing.Size(240, 23);
            this.lblRegisterActive.TabIndex = 1;
            this.lblRegisterActive.Text = "Actives Management Panel";
            // 
            // btnRegisterActive
            // 
            this.btnRegisterActive.Location = new System.Drawing.Point(97, 78);
            this.btnRegisterActive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegisterActive.Name = "btnRegisterActive";
            this.btnRegisterActive.Size = new System.Drawing.Size(100, 28);
            this.btnRegisterActive.TabIndex = 0;
            this.btnRegisterActive.Text = "Register";
            this.btnRegisterActive.UseVisualStyleBackColor = true;
            this.btnRegisterActive.Click += new System.EventHandler(this.btnRegisterActive_Click);
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.Location = new System.Drawing.Point(275, 11);
            this.lblAdminPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(471, 31);
            this.lblAdminPanel.TabIndex = 4;
            this.lblAdminPanel.Text = "Welcome to the admin panel, {0}";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblAdminPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRegisterActive;
        private System.Windows.Forms.Button btnRegisterActive;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnSearchActive;
    }
}