namespace SA43Team2B
{
    partial class BookLendingForm
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
            this.btnLendSubmit = new System.Windows.Forms.Button();
            this.txtLendingRemark = new System.Windows.Forms.TextBox();
            this.DueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.IssueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtLendingMemberName = new System.Windows.Forms.TextBox();
            this.txtLendingMemberId = new System.Windows.Forms.TextBox();
            this.txtLendingBookTitle = new System.Windows.Forms.TextBox();
            this.txtLendingBookCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLendMore = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLendSubmit
            // 
            this.btnLendSubmit.Location = new System.Drawing.Point(149, 383);
            this.btnLendSubmit.Name = "btnLendSubmit";
            this.btnLendSubmit.Size = new System.Drawing.Size(95, 34);
            this.btnLendSubmit.TabIndex = 35;
            this.btnLendSubmit.Text = "Submit";
            this.btnLendSubmit.UseVisualStyleBackColor = true;
            this.btnLendSubmit.Click += new System.EventHandler(this.btnLendSubmit_Click);
            // 
            // txtLendingRemark
            // 
            this.txtLendingRemark.Location = new System.Drawing.Point(129, 265);
            this.txtLendingRemark.Multiline = true;
            this.txtLendingRemark.Name = "txtLendingRemark";
            this.txtLendingRemark.Size = new System.Drawing.Size(200, 92);
            this.txtLendingRemark.TabIndex = 33;
            // 
            // DueDatePicker
            // 
            this.DueDatePicker.Location = new System.Drawing.Point(129, 156);
            this.DueDatePicker.Name = "DueDatePicker";
            this.DueDatePicker.Size = new System.Drawing.Size(200, 20);
            this.DueDatePicker.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Due Date";
            // 
            // IssueDatePicker
            // 
            this.IssueDatePicker.Location = new System.Drawing.Point(129, 115);
            this.IssueDatePicker.Name = "IssueDatePicker";
            this.IssueDatePicker.Size = new System.Drawing.Size(200, 20);
            this.IssueDatePicker.TabIndex = 30;
            // 
            // txtLendingMemberName
            // 
            this.txtLendingMemberName.Location = new System.Drawing.Point(129, 228);
            this.txtLendingMemberName.Name = "txtLendingMemberName";
            this.txtLendingMemberName.ReadOnly = true;
            this.txtLendingMemberName.Size = new System.Drawing.Size(178, 20);
            this.txtLendingMemberName.TabIndex = 29;
            // 
            // txtLendingMemberId
            // 
            this.txtLendingMemberId.Location = new System.Drawing.Point(129, 202);
            this.txtLendingMemberId.Name = "txtLendingMemberId";
            this.txtLendingMemberId.Size = new System.Drawing.Size(97, 20);
            this.txtLendingMemberId.TabIndex = 28;
            this.txtLendingMemberId.Leave += new System.EventHandler(this.txtLendingMemberId_Leave);
            // 
            // txtLendingBookTitle
            // 
            this.txtLendingBookTitle.Location = new System.Drawing.Point(129, 75);
            this.txtLendingBookTitle.Name = "txtLendingBookTitle";
            this.txtLendingBookTitle.ReadOnly = true;
            this.txtLendingBookTitle.Size = new System.Drawing.Size(178, 20);
            this.txtLendingBookTitle.TabIndex = 26;
            // 
            // txtLendingBookCode
            // 
            this.txtLendingBookCode.Location = new System.Drawing.Point(129, 49);
            this.txtLendingBookCode.Name = "txtLendingBookCode";
            this.txtLendingBookCode.Size = new System.Drawing.Size(97, 20);
            this.txtLendingBookCode.TabIndex = 25;
            this.txtLendingBookCode.Leave += new System.EventHandler(this.txtLendingBookCode_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Book Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Remarks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date of Issue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Member ID";
            // 
            // btnLendMore
            // 
            this.btnLendMore.Location = new System.Drawing.Point(36, 383);
            this.btnLendMore.Name = "btnLendMore";
            this.btnLendMore.Size = new System.Drawing.Size(95, 34);
            this.btnLendMore.TabIndex = 37;
            this.btnLendMore.Text = "Lend More...";
            this.btnLendMore.UseVisualStyleBackColor = true;
            this.btnLendMore.Click += new System.EventHandler(this.btnLendMore_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(263, 383);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(97, 34);
            this.btnPrintReceipt.TabIndex = 38;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(730, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // BookLendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(730, 445);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.btnLendMore);
            this.Controls.Add(this.btnLendSubmit);
            this.Controls.Add(this.txtLendingRemark);
            this.Controls.Add(this.DueDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IssueDatePicker);
            this.Controls.Add(this.txtLendingMemberName);
            this.Controls.Add(this.txtLendingMemberId);
            this.Controls.Add(this.txtLendingBookTitle);
            this.Controls.Add(this.txtLendingBookCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "BookLendingForm";
            this.Text = "Book Lending Form";
            this.Load += new System.EventHandler(this.BookLendingForm_Load);
            this.Controls.SetChildIndex(this.ldlUseName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtLendingBookCode, 0);
            this.Controls.SetChildIndex(this.txtLendingBookTitle, 0);
            this.Controls.SetChildIndex(this.txtLendingMemberId, 0);
            this.Controls.SetChildIndex(this.txtLendingMemberName, 0);
            this.Controls.SetChildIndex(this.IssueDatePicker, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.DueDatePicker, 0);
            this.Controls.SetChildIndex(this.txtLendingRemark, 0);
            this.Controls.SetChildIndex(this.btnLendSubmit, 0);
            this.Controls.SetChildIndex(this.btnLendMore, 0);
            this.Controls.SetChildIndex(this.btnPrintReceipt, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLendSubmit;
        private System.Windows.Forms.TextBox txtLendingRemark;
        private System.Windows.Forms.DateTimePicker DueDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker IssueDatePicker;
        private System.Windows.Forms.TextBox txtLendingMemberName;
        private System.Windows.Forms.TextBox txtLendingMemberId;
        private System.Windows.Forms.TextBox txtLendingBookTitle;
        private System.Windows.Forms.TextBox txtLendingBookCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLendMore;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}
