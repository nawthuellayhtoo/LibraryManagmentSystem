namespace SA43Team2B
{
    partial class BookMaintenanceForm
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
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookCode = new System.Windows.Forms.Label();
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.lblBookPublisher = new System.Windows.Forms.Label();
            this.lblBookEdition = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.radioBookTitle = new System.Windows.Forms.RadioButton();
            this.gridBookList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radioBookCode = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookGenre = new System.Windows.Forms.TextBox();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.txtBookEdition = new System.Windows.Forms.TextBox();
            this.grpCriteria = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.txtTotalStock = new System.Windows.Forms.TextBox();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookList)).BeginInit();
            this.grpCriteria.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBookCode
            // 
            this.txtBookCode.Location = new System.Drawing.Point(89, 19);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.ReadOnly = true;
            this.txtBookCode.Size = new System.Drawing.Size(118, 20);
            this.txtBookCode.TabIndex = 12;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(17, 51);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(55, 13);
            this.lblBookTitle.TabIndex = 11;
            this.lblBookTitle.Text = "Book Title";
            // 
            // lblBookCode
            // 
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Location = new System.Drawing.Point(17, 22);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.Size = new System.Drawing.Size(60, 13);
            this.lblBookCode.TabIndex = 10;
            this.lblBookCode.Text = "Book Code";
            // 
            // lblBookGenre
            // 
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.Location = new System.Drawing.Point(230, 22);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(64, 13);
            this.lblBookGenre.TabIndex = 14;
            this.lblBookGenre.Text = "Book Genre";
            // 
            // lblBookPublisher
            // 
            this.lblBookPublisher.AutoSize = true;
            this.lblBookPublisher.Location = new System.Drawing.Point(230, 51);
            this.lblBookPublisher.Name = "lblBookPublisher";
            this.lblBookPublisher.Size = new System.Drawing.Size(78, 13);
            this.lblBookPublisher.TabIndex = 16;
            this.lblBookPublisher.Text = "Book Publisher";
            // 
            // lblBookEdition
            // 
            this.lblBookEdition.AutoSize = true;
            this.lblBookEdition.Location = new System.Drawing.Point(230, 79);
            this.lblBookEdition.Name = "lblBookEdition";
            this.lblBookEdition.Size = new System.Drawing.Size(67, 13);
            this.lblBookEdition.TabIndex = 18;
            this.lblBookEdition.Text = "Book Edition";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(619, 20);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(619, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(619, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.radioBookTitle);
            this.grpSearch.Controls.Add(this.gridBookList);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.radioBookCode);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Location = new System.Drawing.Point(12, 171);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(710, 256);
            this.grpSearch.TabIndex = 23;
            this.grpSearch.TabStop = false;
            // 
            // radioBookTitle
            // 
            this.radioBookTitle.AutoSize = true;
            this.radioBookTitle.Checked = true;
            this.radioBookTitle.Location = new System.Drawing.Point(9, 64);
            this.radioBookTitle.Name = "radioBookTitle";
            this.radioBookTitle.Size = new System.Drawing.Size(73, 17);
            this.radioBookTitle.TabIndex = 25;
            this.radioBookTitle.TabStop = true;
            this.radioBookTitle.Text = "Book Title";
            this.radioBookTitle.UseVisualStyleBackColor = true;
            // 
            // gridBookList
            // 
            this.gridBookList.AllowUserToAddRows = false;
            this.gridBookList.AllowUserToDeleteRows = false;
            this.gridBookList.AllowUserToResizeColumns = false;
            this.gridBookList.AllowUserToResizeRows = false;
            this.gridBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBookList.Location = new System.Drawing.Point(150, 16);
            this.gridBookList.MultiSelect = false;
            this.gridBookList.Name = "gridBookList";
            this.gridBookList.ReadOnly = true;
            this.gridBookList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBookList.Size = new System.Drawing.Size(544, 231);
            this.gridBookList.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(52, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radioBookCode
            // 
            this.radioBookCode.AutoSize = true;
            this.radioBookCode.Location = new System.Drawing.Point(9, 41);
            this.radioBookCode.Name = "radioBookCode";
            this.radioBookCode.Size = new System.Drawing.Size(78, 17);
            this.radioBookCode.TabIndex = 24;
            this.radioBookCode.Text = "Book Code";
            this.radioBookCode.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 93);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(118, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search by";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(89, 48);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(118, 20);
            this.txtBookTitle.TabIndex = 25;
            // 
            // txtBookGenre
            // 
            this.txtBookGenre.Location = new System.Drawing.Point(311, 19);
            this.txtBookGenre.Name = "txtBookGenre";
            this.txtBookGenre.Size = new System.Drawing.Size(118, 20);
            this.txtBookGenre.TabIndex = 26;
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Location = new System.Drawing.Point(311, 48);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(118, 20);
            this.txtBookPublisher.TabIndex = 27;
            // 
            // txtBookEdition
            // 
            this.txtBookEdition.Location = new System.Drawing.Point(311, 76);
            this.txtBookEdition.Name = "txtBookEdition";
            this.txtBookEdition.Size = new System.Drawing.Size(118, 20);
            this.txtBookEdition.TabIndex = 28;
            // 
            // grpCriteria
            // 
            this.grpCriteria.Controls.Add(this.btnClear);
            this.grpCriteria.Controls.Add(this.txtBookAuthor);
            this.grpCriteria.Controls.Add(this.lblBookAuthor);
            this.grpCriteria.Controls.Add(this.txtTotalStock);
            this.grpCriteria.Controls.Add(this.txtBookEdition);
            this.grpCriteria.Controls.Add(this.lblTotalStock);
            this.grpCriteria.Controls.Add(this.lblBookCode);
            this.grpCriteria.Controls.Add(this.lblBookGenre);
            this.grpCriteria.Controls.Add(this.btnDelete);
            this.grpCriteria.Controls.Add(this.lblBookPublisher);
            this.grpCriteria.Controls.Add(this.txtBookCode);
            this.grpCriteria.Controls.Add(this.txtBookPublisher);
            this.grpCriteria.Controls.Add(this.lblBookEdition);
            this.grpCriteria.Controls.Add(this.txtBookTitle);
            this.grpCriteria.Controls.Add(this.btnInsert);
            this.grpCriteria.Controls.Add(this.txtBookGenre);
            this.grpCriteria.Controls.Add(this.lblBookTitle);
            this.grpCriteria.Controls.Add(this.btnUpdate);
            this.grpCriteria.Location = new System.Drawing.Point(12, 36);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.Size = new System.Drawing.Size(710, 129);
            this.grpCriteria.TabIndex = 29;
            this.grpCriteria.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(619, 98);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 22);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(89, 76);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(118, 20);
            this.txtBookAuthor.TabIndex = 34;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(17, 79);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(66, 13);
            this.lblBookAuthor.TabIndex = 33;
            this.lblBookAuthor.Text = "Book Author";
            // 
            // txtTotalStock
            // 
            this.txtTotalStock.Location = new System.Drawing.Point(513, 19);
            this.txtTotalStock.Name = "txtTotalStock";
            this.txtTotalStock.Size = new System.Drawing.Size(42, 20);
            this.txtTotalStock.TabIndex = 32;
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Location = new System.Drawing.Point(445, 22);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(62, 13);
            this.lblTotalStock.TabIndex = 31;
            this.lblTotalStock.Text = "Total Stock";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusStrip});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(734, 22);
            this.statusStrip.TabIndex = 30;
            // 
            // lblStatusStrip
            // 
            this.lblStatusStrip.Name = "lblStatusStrip";
            this.lblStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // BookMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpCriteria);
            this.Name = "BookMaintenanceForm";
            this.Text = "Book Maintenance System";
            this.Load += new System.EventHandler(this.BookMaintenanceForm_Load);
            this.Controls.SetChildIndex(this.ldlUseName, 0);
            this.Controls.SetChildIndex(this.grpCriteria, 0);
            this.Controls.SetChildIndex(this.grpSearch, 0);
            this.Controls.SetChildIndex(this.statusStrip, 0);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookList)).EndInit();
            this.grpCriteria.ResumeLayout(false);
            this.grpCriteria.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.Label lblBookGenre;
        private System.Windows.Forms.Label lblBookPublisher;
        private System.Windows.Forms.Label lblBookEdition;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton radioBookTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioBookCode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView gridBookList;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookGenre;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.TextBox txtBookEdition;
        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox txtTotalStock;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusStrip;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Button btnClear;
    }
}
