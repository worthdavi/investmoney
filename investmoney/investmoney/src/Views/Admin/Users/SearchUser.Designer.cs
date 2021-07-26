
namespace investmoney.src.Views.Admin.Users
{
    partial class SearchUser
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
            this.UserTable = new System.Windows.Forms.DataGridView();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cBoxSearchBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // UserTable
            // 
            this.UserTable.AllowUserToAddRows = false;
            this.UserTable.AllowUserToDeleteRows = false;
            this.UserTable.AllowUserToResizeColumns = false;
            this.UserTable.AllowUserToResizeRows = false;
            this.UserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserTable.GridColor = System.Drawing.Color.Maroon;
            this.UserTable.Location = new System.Drawing.Point(11, 52);
            this.UserTable.MultiSelect = false;
            this.UserTable.Name = "UserTable";
            this.UserTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserTable.RowHeadersVisible = false;
            this.UserTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.UserTable.Size = new System.Drawing.Size(500, 275);
            this.UserTable.TabIndex = 0;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(11, 26);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(342, 20);
            this.txtSearchUser.TabIndex = 1;
            // 
            // imgSearch
            // 
            this.imgSearch.BackColor = System.Drawing.Color.Transparent;
            this.imgSearch.BackgroundImage = global::investmoney.Properties.Resources.search_icon1;
            this.imgSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSearch.InitialImage = global::investmoney.Properties.Resources.search_icon1;
            this.imgSearch.Location = new System.Drawing.Point(486, 26);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(25, 20);
            this.imgSearch.TabIndex = 2;
            this.imgSearch.TabStop = false;
            this.imgSearch.Click += new System.EventHandler(this.imgSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(8, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search for:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(344, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(435, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(356, 9);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(58, 13);
            this.lblSearchBy.TabIndex = 7;
            this.lblSearchBy.Text = "Search by:";
            // 
            // cBoxSearchBy
            // 
            this.cBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSearchBy.FormattingEnabled = true;
            this.cBoxSearchBy.Items.AddRange(new object[] {
            "Username",
            "Email"});
            this.cBoxSearchBy.Location = new System.Drawing.Point(359, 25);
            this.cBoxSearchBy.Name = "cBoxSearchBy";
            this.cBoxSearchBy.Size = new System.Drawing.Size(121, 21);
            this.cBoxSearchBy.TabIndex = 8;
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 385);
            this.Controls.Add(this.cBoxSearchBy);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.imgSearch);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.UserTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserTable;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.PictureBox imgSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cBoxSearchBy;
    }
}