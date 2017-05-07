namespace SA43Team2B
{
    partial class MemberMaintenanceForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.gridCustomerList = new System.Windows.Forms.DataGridView();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.radioMemberName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radioMemberID = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpCriteria = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.radioPremiumType = new System.Windows.Forms.RadioButton();
            this.radioRegularType = new System.Windows.Forms.RadioButton();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusStrip});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(734, 22);
            this.statusStrip.TabIndex = 34;
            // 
            // lblStatusStrip
            // 
            this.lblStatusStrip.Name = "lblStatusStrip";
            this.lblStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // gridCustomerList
            // 
            this.gridCustomerList.AllowUserToAddRows = false;
            this.gridCustomerList.AllowUserToDeleteRows = false;
            this.gridCustomerList.AllowUserToResizeColumns = false;
            this.gridCustomerList.AllowUserToResizeRows = false;
            this.gridCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomerList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridCustomerList.Location = new System.Drawing.Point(154, 18);
            this.gridCustomerList.MultiSelect = false;
            this.gridCustomerList.Name = "gridCustomerList";
            this.gridCustomerList.ReadOnly = true;
            this.gridCustomerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCustomerList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomerList.Size = new System.Drawing.Size(541, 231);
            this.gridCustomerList.TabIndex = 32;
            this.gridCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCustomerList_CellContentClick);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.radioMemberName);
            this.grpSearch.Controls.Add(this.gridCustomerList);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.radioMemberID);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Location = new System.Drawing.Point(12, 170);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(710, 256);
            this.grpSearch.TabIndex = 31;
            this.grpSearch.TabStop = false;
            // 
            // radioMemberName
            // 
            this.radioMemberName.AutoSize = true;
            this.radioMemberName.Checked = true;
            this.radioMemberName.Location = new System.Drawing.Point(9, 64);
            this.radioMemberName.Name = "radioMemberName";
            this.radioMemberName.Size = new System.Drawing.Size(94, 17);
            this.radioMemberName.TabIndex = 25;
            this.radioMemberName.TabStop = true;
            this.radioMemberName.Text = "Member Name";
            this.radioMemberName.UseVisualStyleBackColor = true;
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
            // radioMemberID
            // 
            this.radioMemberID.AutoSize = true;
            this.radioMemberID.Location = new System.Drawing.Point(9, 41);
            this.radioMemberID.Name = "radioMemberID";
            this.radioMemberID.Size = new System.Drawing.Size(77, 17);
            this.radioMemberID.TabIndex = 24;
            this.radioMemberID.Text = "Member ID";
            this.radioMemberID.UseVisualStyleBackColor = true;
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
            // grpCriteria
            // 
            this.grpCriteria.Controls.Add(this.btnClear);
            this.grpCriteria.Controls.Add(this.txtAddress);
            this.grpCriteria.Controls.Add(this.radioPremiumType);
            this.grpCriteria.Controls.Add(this.radioRegularType);
            this.grpCriteria.Controls.Add(this.lblMemberType);
            this.grpCriteria.Controls.Add(this.lblMemberID);
            this.grpCriteria.Controls.Add(this.lblPhone);
            this.grpCriteria.Controls.Add(this.btnDelete);
            this.grpCriteria.Controls.Add(this.lblEmail);
            this.grpCriteria.Controls.Add(this.txtMemberID);
            this.grpCriteria.Controls.Add(this.txtEmail);
            this.grpCriteria.Controls.Add(this.lblAddress);
            this.grpCriteria.Controls.Add(this.txtMemberName);
            this.grpCriteria.Controls.Add(this.btnInsert);
            this.grpCriteria.Controls.Add(this.txtPhone);
            this.grpCriteria.Controls.Add(this.lblMemberName);
            this.grpCriteria.Controls.Add(this.btnUpdate);
            this.grpCriteria.Location = new System.Drawing.Point(12, 35);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.Size = new System.Drawing.Size(710, 129);
            this.grpCriteria.TabIndex = 33;
            this.grpCriteria.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(489, 22);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(118, 74);
            this.txtAddress.TabIndex = 32;
            // 
            // radioPremiumType
            // 
            this.radioPremiumType.AutoSize = true;
            this.radioPremiumType.Location = new System.Drawing.Point(172, 79);
            this.radioPremiumType.Name = "radioPremiumType";
            this.radioPremiumType.Size = new System.Drawing.Size(65, 17);
            this.radioPremiumType.TabIndex = 31;
            this.radioPremiumType.TabStop = true;
            this.radioPremiumType.Text = "Premium";
            this.radioPremiumType.UseVisualStyleBackColor = true;
            // 
            // radioRegularType
            // 
            this.radioRegularType.AutoSize = true;
            this.radioRegularType.Checked = true;
            this.radioRegularType.Location = new System.Drawing.Point(104, 79);
            this.radioRegularType.Name = "radioRegularType";
            this.radioRegularType.Size = new System.Drawing.Size(62, 17);
            this.radioRegularType.TabIndex = 30;
            this.radioRegularType.TabStop = true;
            this.radioRegularType.Text = "Regular";
            this.radioRegularType.UseVisualStyleBackColor = true;
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Location = new System.Drawing.Point(17, 79);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(72, 13);
            this.lblMemberType.TabIndex = 29;
            this.lblMemberType.Text = "Member Type";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(17, 25);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(59, 13);
            this.lblMemberID.TabIndex = 10;
            this.lblMemberID.Text = "Member ID";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(244, 25);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(629, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(250, 51);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(104, 22);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(118, 20);
            this.txtMemberID.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(304, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(118, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(438, 25);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(104, 48);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(118, 20);
            this.txtMemberName.TabIndex = 25;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(629, 22);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(304, 22);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(118, 20);
            this.txtPhone.TabIndex = 26;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(17, 51);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(76, 13);
            this.lblMemberName.TabIndex = 11;
            this.lblMemberName.Text = "Member Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(629, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(631, 101);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 22);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MemberMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpCriteria);
            this.Name = "MemberMaintenanceForm";
            this.Text = "Member Maintenance System";
            this.Load += new System.EventHandler(this.MemberMaintenanceForm_Load);
            this.Controls.SetChildIndex(this.ldlUseName, 0);
            this.Controls.SetChildIndex(this.grpCriteria, 0);
            this.Controls.SetChildIndex(this.grpSearch, 0);
            this.Controls.SetChildIndex(this.statusStrip, 0);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpCriteria.ResumeLayout(false);
            this.grpCriteria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.DataGridView gridCustomerList;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton radioMemberName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioMemberID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton radioPremiumType;
        private System.Windows.Forms.RadioButton radioRegularType;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusStrip;
        private System.Windows.Forms.Button btnClear;
    }
}
