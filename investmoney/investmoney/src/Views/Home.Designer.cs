
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTableActives = new System.Windows.Forms.DataGridView();
            this.btnPainelAdministrativo = new System.Windows.Forms.Button();
            this.pnlLogoHome = new System.Windows.Forms.Panel();
            this.btnBuyActives = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTableHistory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableActives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableActives
            // 
            this.dataTableActives.AllowUserToAddRows = false;
            this.dataTableActives.AllowUserToDeleteRows = false;
            this.dataTableActives.AllowUserToResizeColumns = false;
            this.dataTableActives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableActives.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataTableActives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableActives.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataTableActives.GridColor = System.Drawing.Color.White;
            this.dataTableActives.Location = new System.Drawing.Point(376, 4);
            this.dataTableActives.MultiSelect = false;
            this.dataTableActives.Name = "dataTableActives";
            this.dataTableActives.ReadOnly = true;
            this.dataTableActives.RowHeadersVisible = false;
            this.dataTableActives.RowHeadersWidth = 51;
            this.dataTableActives.Size = new System.Drawing.Size(569, 199);
            this.dataTableActives.TabIndex = 2;
            // 
            // btnPainelAdministrativo
            // 
            this.btnPainelAdministrativo.BackgroundImage = global::investmoney.Properties.Resources.Engrenagem_Bicolor_PNG;
            this.btnPainelAdministrativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPainelAdministrativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPainelAdministrativo.Location = new System.Drawing.Point(6, 359);
            this.btnPainelAdministrativo.Name = "btnPainelAdministrativo";
            this.btnPainelAdministrativo.Size = new System.Drawing.Size(35, 33);
            this.btnPainelAdministrativo.TabIndex = 9;
            this.btnPainelAdministrativo.UseVisualStyleBackColor = true;
            this.btnPainelAdministrativo.Visible = false;
            this.btnPainelAdministrativo.Click += new System.EventHandler(this.btnPainelAdministrativo_Click);
            // 
            // pnlLogoHome
            // 
            this.pnlLogoHome.BackgroundImage = global::investmoney.Properties.Resources.investmoney_brand;
            this.pnlLogoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogoHome.Location = new System.Drawing.Point(6, 4);
            this.pnlLogoHome.Name = "pnlLogoHome";
            this.pnlLogoHome.Size = new System.Drawing.Size(344, 100);
            this.pnlLogoHome.TabIndex = 8;
            // 
            // btnBuyActives
            // 
            this.btnBuyActives.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuyActives.BackColor = System.Drawing.Color.Transparent;
            this.btnBuyActives.BackgroundImage = global::investmoney.Properties.Resources.buynow;
            this.btnBuyActives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuyActives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyActives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyActives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuyActives.Location = new System.Drawing.Point(185, 359);
            this.btnBuyActives.Name = "btnBuyActives";
            this.btnBuyActives.Size = new System.Drawing.Size(165, 49);
            this.btnBuyActives.TabIndex = 3;
            this.btnBuyActives.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuyActives.UseVisualStyleBackColor = false;
            this.btnBuyActives.Click += new System.EventHandler(this.btnBuyActives_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Or click here to sell your actions";
            this.label1.Click += new System.EventHandler(this.btnSellActives_Click);
            // 
            // dataTableHistory
            // 
            this.dataTableHistory.AllowUserToAddRows = false;
            this.dataTableHistory.AllowUserToDeleteRows = false;
            this.dataTableHistory.AllowUserToResizeColumns = false;
            this.dataTableHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableHistory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataTableHistory.ColumnHeadersHeight = 29;
            this.dataTableHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTableHistory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataTableHistory.GridColor = System.Drawing.Color.White;
            this.dataTableHistory.Location = new System.Drawing.Point(376, 222);
            this.dataTableHistory.Name = "dataTableHistory";
            this.dataTableHistory.ReadOnly = true;
            this.dataTableHistory.RowHeadersVisible = false;
            this.dataTableHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataTableHistory.Size = new System.Drawing.Size(569, 200);
            this.dataTableHistory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "This is your wallet.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "This is your transactions history.";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 249);
            this.label4.TabIndex = 15;
            this.label4.Text = "Welcome to your homepage. Here you can see your actions balance and more!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Relatórios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuyActives);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataTableHistory);
            this.Controls.Add(this.btnPainelAdministrativo);
            this.Controls.Add(this.pnlLogoHome);
            this.Controls.Add(this.dataTableActives);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - {0}";
            this.Activated += new System.EventHandler(this.Home_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableActives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataTableActives;
        private System.Windows.Forms.Panel pnlLogoHome;
        private System.Windows.Forms.Button btnPainelAdministrativo;
        private System.Windows.Forms.Button btnBuyActives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataTableHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}