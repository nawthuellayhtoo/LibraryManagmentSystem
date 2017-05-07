namespace SA43Team2B
{
    partial class BookSearchForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCheckAvailable = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.GridSearchResult = new System.Windows.Forms.DataGridView();
            this.grpBookSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.radioBookGenre = new System.Windows.Forms.RadioButton();
            this.radioBookAuthor = new System.Windows.Forms.RadioButton();
            this.radioBookTitle = new System.Windows.Forms.RadioButton();
            this.radioBookCode = new System.Windows.Forms.RadioButton();
            this.statusStripSearch = new System.Windows.Forms.StatusStrip();
            this.toolStripSearchStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearchResult)).BeginInit();
            this.grpBookSearch.SuspendLayout();
            this.statusStripSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(74, 4);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Location = new System.Drawing.Point(20, 255);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 28);
            this.txtSearch.TabIndex = 7;
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClear.Location = new System.Drawing.Point(20, 339);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(114, 53);
            this.btnSearchClear.TabIndex = 12;
            this.btnSearchClear.Text = "Clear";
            this.btnSearchClear.UseVisualStyleBackColor = true;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(152, 339);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 53);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCheckAvailable
            // 
            this.btnCheckAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAvailable.Location = new System.Drawing.Point(660, 531);
            this.btnCheckAvailable.Name = "btnCheckAvailable";
            this.btnCheckAvailable.Size = new System.Drawing.Size(254, 53);
            this.btnCheckAvailable.TabIndex = 14;
            this.btnCheckAvailable.Text = "Check Available Date";
            this.btnCheckAvailable.UseVisualStyleBackColor = true;
            this.btnCheckAvailable.Click += new System.EventHandler(this.btnCheckAvailable_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Location = new System.Drawing.Point(952, 531);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(104, 53);
            this.btnBorrow.TabIndex = 15;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // GridSearchResult
            // 
            this.GridSearchResult.AllowUserToDeleteRows = false;
            this.GridSearchResult.AllowUserToOrderColumns = true;
            this.GridSearchResult.AllowUserToResizeColumns = false;
            this.GridSearchResult.AllowUserToResizeRows = false;
            this.GridSearchResult.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.GridSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSearchResult.Location = new System.Drawing.Point(320, 78);
            this.GridSearchResult.Name = "GridSearchResult";
            this.GridSearchResult.RowTemplate.Height = 30;
            this.GridSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSearchResult.Size = new System.Drawing.Size(754, 413);
            this.GridSearchResult.TabIndex = 17;
            // 
            // grpBookSearch
            // 
            this.grpBookSearch.Controls.Add(this.lblSearchCriteria);
            this.grpBookSearch.Controls.Add(this.radioBookGenre);
            this.grpBookSearch.Controls.Add(this.radioBookAuthor);
            this.grpBookSearch.Controls.Add(this.radioBookTitle);
            this.grpBookSearch.Controls.Add(this.radioBookCode);
            this.grpBookSearch.Controls.Add(this.btnSearch);
            this.grpBookSearch.Controls.Add(this.btnSearchClear);
            this.grpBookSearch.Controls.Add(this.txtSearch);
            this.grpBookSearch.Location = new System.Drawing.Point(12, 71);
            this.grpBookSearch.Name = "grpBookSearch";
            this.grpBookSearch.Size = new System.Drawing.Size(286, 420);
            this.grpBookSearch.TabIndex = 18;
            this.grpBookSearch.TabStop = false;
            // 
            // lblSearchCriteria
            // 
            this.lblSearchCriteria.AutoSize = true;
            this.lblSearchCriteria.Location = new System.Drawing.Point(6, 24);
            this.lblSearchCriteria.Name = "lblSearchCriteria";
            this.lblSearchCriteria.Size = new System.Drawing.Size(143, 18);
            this.lblSearchCriteria.TabIndex = 18;
            this.lblSearchCriteria.Text = "Search Criteria";
            // 
            // radioBookGenre
            // 
            this.radioBookGenre.AutoSize = true;
            this.radioBookGenre.Location = new System.Drawing.Point(7, 182);
            this.radioBookGenre.Name = "radioBookGenre";
            this.radioBookGenre.Size = new System.Drawing.Size(123, 22);
            this.radioBookGenre.TabIndex = 17;
            this.radioBookGenre.Text = "Book Genre";
            this.radioBookGenre.UseVisualStyleBackColor = true;
            // 
            // radioBookAuthor
            // 
            this.radioBookAuthor.AutoSize = true;
            this.radioBookAuthor.Location = new System.Drawing.Point(7, 139);
            this.radioBookAuthor.Name = "radioBookAuthor";
            this.radioBookAuthor.Size = new System.Drawing.Size(132, 22);
            this.radioBookAuthor.TabIndex = 16;
            this.radioBookAuthor.Text = "Book Author";
            this.radioBookAuthor.UseVisualStyleBackColor = true;
            // 
            // radioBookTitle
            // 
            this.radioBookTitle.AutoSize = true;
            this.radioBookTitle.Location = new System.Drawing.Point(7, 99);
            this.radioBookTitle.Name = "radioBookTitle";
            this.radioBookTitle.Size = new System.Drawing.Size(123, 22);
            this.radioBookTitle.TabIndex = 15;
            this.radioBookTitle.Text = "Book Title";
            this.radioBookTitle.UseVisualStyleBackColor = true;
            // 
            // radioBookCode
            // 
            this.radioBookCode.AutoSize = true;
            this.radioBookCode.Checked = true;
            this.radioBookCode.Location = new System.Drawing.Point(7, 56);
            this.radioBookCode.Name = "radioBookCode";
            this.radioBookCode.Size = new System.Drawing.Size(114, 22);
            this.radioBookCode.TabIndex = 14;
            this.radioBookCode.TabStop = true;
            this.radioBookCode.Text = "Book Code";
            this.radioBookCode.UseVisualStyleBackColor = true;
            // 
            // statusStripSearch
            // 
            this.statusStripSearch.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSearchStatus,
            this.toolStripStatusLabel1});
            this.statusStripSearch.Location = new System.Drawing.Point(0, 616);
            this.statusStripSearch.Name = "statusStripSearch";
            this.statusStripSearch.Size = new System.Drawing.Size(1101, 22);
            this.statusStripSearch.TabIndex = 19;
            // 
            // toolStripSearchStatus
            // 
            this.toolStripSearchStatus.Name = "toolStripSearchStatus";
            this.toolStripSearchStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // BookSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1101, 638);
            this.Controls.Add(this.statusStripSearch);
            this.Controls.Add(this.grpBookSearch);
            this.Controls.Add(this.GridSearchResult);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnCheckAvailable);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "BookSearchForm";
            this.Text = "Book Search Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.btnCheckAvailable, 0);
            this.Controls.SetChildIndex(this.btnBorrow, 0);
            this.Controls.SetChildIndex(this.GridSearchResult, 0);
            this.Controls.SetChildIndex(this.grpBookSearch, 0);
            this.Controls.SetChildIndex(this.statusStripSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridSearchResult)).EndInit();
            this.grpBookSearch.ResumeLayout(false);
            this.grpBookSearch.PerformLayout();
            this.statusStripSearch.ResumeLayout(false);
            this.statusStripSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCheckAvailable;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.DataGridView GridSearchResult;
        private System.Windows.Forms.GroupBox grpBookSearch;
        private System.Windows.Forms.Label lblSearchCriteria;
        private System.Windows.Forms.RadioButton radioBookGenre;
        private System.Windows.Forms.RadioButton radioBookAuthor;
        private System.Windows.Forms.RadioButton radioBookTitle;
        private System.Windows.Forms.RadioButton radioBookCode;
        private System.Windows.Forms.StatusStrip statusStripSearch;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSearchStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
