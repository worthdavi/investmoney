
namespace investmoney.src.Views.Admin.Actives
{
    partial class SearchActive
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
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchActive = new System.Windows.Forms.TextBox();
            this.cBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ActiveTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(356, 8);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(58, 13);
            this.lblSearchBy.TabIndex = 10;
            this.lblSearchBy.Text = "Search by:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(8, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 13);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search for:";
            // 
            // txtSearchActive
            // 
            this.txtSearchActive.Location = new System.Drawing.Point(11, 25);
            this.txtSearchActive.Name = "txtSearchActive";
            this.txtSearchActive.Size = new System.Drawing.Size(342, 20);
            this.txtSearchActive.TabIndex = 8;
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
            this.cBoxSearchBy.TabIndex = 12;
            // 
            // imgSearch
            // 
            this.imgSearch.BackColor = System.Drawing.Color.Transparent;
            this.imgSearch.BackgroundImage = global::investmoney.Properties.Resources.search_icon1;
            this.imgSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSearch.InitialImage = global::investmoney.Properties.Resources.search_icon1;
            this.imgSearch.Location = new System.Drawing.Point(486, 25);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(25, 20);
            this.imgSearch.TabIndex = 11;
            this.imgSearch.TabStop = false;
            this.imgSearch.Click += new System.EventHandler(this.imgSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(436, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(339, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ActiveTable
            // 
            this.ActiveTable.AllowUserToAddRows = false;
            this.ActiveTable.AllowUserToDeleteRows = false;
            this.ActiveTable.AllowUserToResizeColumns = false;
            this.ActiveTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActiveTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ActiveTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ActiveTable.GridColor = System.Drawing.Color.White;
            this.ActiveTable.Name = "dataTableHistory";
            this.ActiveTable.ReadOnly = false;
            this.ActiveTable.RowHeadersVisible = false;
            this.ActiveTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ActiveTable.TabIndex = 3;
            this.ActiveTable.Location = new System.Drawing.Point(11, 55);
            this.ActiveTable.Size = new System.Drawing.Size(500, 275);
            // 
            // SearchActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 385);
            this.Controls.Add(this.ActiveTable);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cBoxSearchBy);
            this.Controls.Add(this.imgSearch);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchActive);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchActive";
            this.Text = "SearchActive";
            this.Load += new System.EventHandler(this.SearchActive_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchActive;
        private System.Windows.Forms.ComboBox cBoxSearchBy;
        private System.Windows.Forms.PictureBox imgSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView ActiveTable;
    }
}