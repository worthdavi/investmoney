
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
            this.lblPainelAdministrativo = new System.Windows.Forms.Label();
            this.lblWalletTitle = new System.Windows.Forms.Label();
            this.dataTableActives = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableActives)).BeginInit();
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
            this.lblWalletTitle.Location = new System.Drawing.Point(414, 9);
            this.lblWalletTitle.Name = "lblWalletTitle";
            this.lblWalletTitle.Size = new System.Drawing.Size(95, 41);
            this.lblWalletTitle.TabIndex = 1;
            this.lblWalletTitle.Text = "Wallet";
            // 
            // dataTableActives
            // 
            this.dataTableActives.AllowUserToAddRows = false;
            this.dataTableActives.AllowUserToDeleteRows = false;
            this.dataTableActives.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataTableActives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableActives.GridColor = System.Drawing.Color.White;
            this.dataTableActives.Location = new System.Drawing.Point(110, 53);
            this.dataTableActives.Name = "dataTableActives";
            this.dataTableActives.ReadOnly = true;
            this.dataTableActives.Size = new System.Drawing.Size(707, 236);
            this.dataTableActives.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.dataTableActives);
            this.Controls.Add(this.lblWalletTitle);
            this.Controls.Add(this.lblPainelAdministrativo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - {0}";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableActives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPainelAdministrativo;
        private System.Windows.Forms.Label lblWalletTitle;
        private System.Windows.Forms.DataGridView dataTableActives;
    }
}