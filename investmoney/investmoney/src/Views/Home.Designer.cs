
namespace investmoney.src.Views
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPainelAdministrativo = new System.Windows.Forms.Label();
            this.lblWalletTitle = new System.Windows.Forms.Label();
            this.dataTableActives = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblActivesBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableActives)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPainelAdministrativo
            // 
            this.lblPainelAdministrativo.AutoSize = true;
            this.lblPainelAdministrativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPainelAdministrativo.Enabled = false;
            this.lblPainelAdministrativo.Location = new System.Drawing.Point(795, 9);
            this.lblPainelAdministrativo.Name = "lblPainelAdministrativo";
            this.lblPainelAdministrativo.Size = new System.Drawing.Size(104, 13);
            this.lblPainelAdministrativo.TabIndex = 0;
            this.lblPainelAdministrativo.Text = "Painel Administrativo";
            this.lblPainelAdministrativo.Visible = false;
            this.lblPainelAdministrativo.Click += new System.EventHandler(this.lblPainelAdministrativo_Click);
            // 
            // lblWalletTitle
            // 
            this.lblWalletTitle.AutoSize = true;
            this.lblWalletTitle.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWalletTitle.ForeColor = System.Drawing.Color.Red;
            this.lblWalletTitle.Location = new System.Drawing.Point(316, 9);
            this.lblWalletTitle.Name = "lblWalletTitle";
            this.lblWalletTitle.Size = new System.Drawing.Size(281, 41);
            this.lblWalletTitle.TabIndex = 1;
            this.lblWalletTitle.Text = "Welcome to your wallet";
            // 
            // dataTableActives
            // 
            this.dataTableActives.AllowUserToAddRows = false;
            this.dataTableActives.AllowUserToDeleteRows = false;
            this.dataTableActives.AllowUserToResizeColumns = false;
            this.dataTableActives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableActives.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataTableActives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableActives.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataTableActives.GridColor = System.Drawing.Color.White;
            this.dataTableActives.Location = new System.Drawing.Point(12, 53);
            this.dataTableActives.MultiSelect = false;
            this.dataTableActives.Name = "dataTableActives";
            this.dataTableActives.ReadOnly = true;
            this.dataTableActives.RowHeadersVisible = false;
            this.dataTableActives.Size = new System.Drawing.Size(887, 246);
            this.dataTableActives.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUY ACTIVES";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "SELL ACTIVES";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(628, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 133);
            this.panel1.TabIndex = 5;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(9, 37);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(118, 13);
            this.lblAccountBalance.TabIndex = 6;
            this.lblAccountBalance.Text = "Account Balance Label";
            // 
            // lblActivesBalance
            // 
            this.lblActivesBalance.AutoSize = true;
            this.lblActivesBalance.Location = new System.Drawing.Point(9, 302);
            this.lblActivesBalance.Name = "lblActivesBalance";
            this.lblActivesBalance.Size = new System.Drawing.Size(129, 13);
            this.lblActivesBalance.TabIndex = 7;
            this.lblActivesBalance.Text = "Your actives balance is: ?";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.lblActivesBalance);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.dataTableActives);
            this.Controls.Add(this.lblWalletTitle);
            this.Controls.Add(this.lblPainelAdministrativo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - {0}";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableActives)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPainelAdministrativo;
        private System.Windows.Forms.Label lblWalletTitle;
        private System.Windows.Forms.DataGridView dataTableActives;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblActivesBalance;
    }
}