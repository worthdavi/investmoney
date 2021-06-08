
namespace wallstreet.src.Views
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.lblPainelAdministrativo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPainelAdministrativo;
    }
}