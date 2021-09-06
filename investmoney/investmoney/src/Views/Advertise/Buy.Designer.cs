
namespace investmoney.src.Views.Advertise
{
    partial class Buy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTableActives = new System.Windows.Forms.DataGridView();
            this.txtOfferId = new System.Windows.Forms.TextBox();
            this.lblOffer = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Panel();
            this.lblAmountError = new System.Windows.Forms.Label();
            this.lblOfferError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableActives)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::investmoney.Properties.Resources.investmoney_brand;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(279, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "BOARD";
            // 
            // dataTableActives
            // 
            this.dataTableActives.AllowUserToAddRows = false;
            this.dataTableActives.AllowUserToDeleteRows = false;
            this.dataTableActives.AllowUserToOrderColumns = true;
            this.dataTableActives.AllowUserToResizeColumns = false;
            this.dataTableActives.AllowUserToResizeRows = false;
            this.dataTableActives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableActives.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataTableActives.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataTableActives.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataTableActives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableActives.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataTableActives.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTableActives.GridColor = System.Drawing.Color.White;
            this.dataTableActives.Location = new System.Drawing.Point(43, 162);
            this.dataTableActives.MultiSelect = false;
            this.dataTableActives.Name = "dataTableActives";
            this.dataTableActives.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableActives.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTableActives.RowHeadersVisible = false;
            this.dataTableActives.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataTableActives.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableActives.ShowCellErrors = false;
            this.dataTableActives.ShowCellToolTips = false;
            this.dataTableActives.ShowEditingIcon = false;
            this.dataTableActives.ShowRowErrors = false;
            this.dataTableActives.Size = new System.Drawing.Size(716, 150);
            this.dataTableActives.TabIndex = 2;
            // 
            // txtOfferId
            // 
            this.txtOfferId.Location = new System.Drawing.Point(659, 326);
            this.txtOfferId.Name = "txtOfferId";
            this.txtOfferId.Size = new System.Drawing.Size(100, 20);
            this.txtOfferId.TabIndex = 3;
            this.txtOfferId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOfferId_KeyDown);
            this.txtOfferId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbers_KeyPress);
            // 
            // lblOffer
            // 
            this.lblOffer.AutoSize = true;
            this.lblOffer.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffer.Location = new System.Drawing.Point(575, 326);
            this.lblOffer.Name = "lblOffer";
            this.lblOffer.Size = new System.Drawing.Size(78, 18);
            this.lblOffer.TabIndex = 4;
            this.lblOffer.Text = "Offert ID:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(583, 370);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(70, 18);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(659, 370);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbers_KeyPress);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(669, 410);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(85, 28);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(43, 319);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(157, 18);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "Your balance: {0} R$";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::investmoney.Properties.Resources.arrow_go_back;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Location = new System.Drawing.Point(46, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(38, 34);
            this.btnHome.TabIndex = 11;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblAmountError
            // 
            this.lblAmountError.AutoSize = true;
            this.lblAmountError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountError.ForeColor = System.Drawing.Color.Red;
            this.lblAmountError.Location = new System.Drawing.Point(657, 393);
            this.lblAmountError.Name = "lblAmountError";
            this.lblAmountError.Size = new System.Drawing.Size(82, 12);
            this.lblAmountError.TabIndex = 12;
            this.lblAmountError.Text = "Not enough money";
            this.lblAmountError.Visible = false;
            // 
            // lblOfferError
            // 
            this.lblOfferError.AutoSize = true;
            this.lblOfferError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferError.ForeColor = System.Drawing.Color.Red;
            this.lblOfferError.Location = new System.Drawing.Point(657, 349);
            this.lblOfferError.Name = "lblOfferError";
            this.lblOfferError.Size = new System.Drawing.Size(54, 12);
            this.lblOfferError.TabIndex = 13;
            this.lblOfferError.Text = "Invalid offer";
            this.lblOfferError.Visible = false;
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOfferError);
            this.Controls.Add(this.lblAmountError);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblOffer);
            this.Controls.Add(this.txtOfferId);
            this.Controls.Add(this.dataTableActives);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Buy";
            this.Text = "Buy";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableActives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataTableActives;
        private System.Windows.Forms.TextBox txtOfferId;
        private System.Windows.Forms.Label lblOffer;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Panel btnHome;
        private System.Windows.Forms.Label lblAmountError;
        private System.Windows.Forms.Label lblOfferError;
    }
}