namespace SA43Team2B
{
    partial class BookReturnForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReturnTransactionId = new System.Windows.Forms.TextBox();
            this.txtReturnBookCode = new System.Windows.Forms.TextBox();
            this.txtReturnBookTitle = new System.Windows.Forms.TextBox();
            this.txtReturnMemberName = new System.Windows.Forms.TextBox();
            this.txtReturnMemberId = new System.Windows.Forms.TextBox();
            this.ReturnDueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ReturnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtReturnRemark = new System.Windows.Forms.TextBox();
            this.btnReturnSubmit = new System.Windows.Forms.Button();
            this.lblTransactionIdError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Member ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Remarks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Transaction ID";
            // 
            // txtReturnTransactionId
            // 
            this.txtReturnTransactionId.Location = new System.Drawing.Point(146, 53);
            this.txtReturnTransactionId.Name = "txtReturnTransactionId";
            this.txtReturnTransactionId.Size = new System.Drawing.Size(97, 20);
            this.txtReturnTransactionId.TabIndex = 9;
            this.txtReturnTransactionId.Leave += new System.EventHandler(this.txtReturnTransactionId_Leave);
            // 
            // txtReturnBookCode
            // 
            this.txtReturnBookCode.Location = new System.Drawing.Point(146, 91);
            this.txtReturnBookCode.Name = "txtReturnBookCode";
            this.txtReturnBookCode.Size = new System.Drawing.Size(97, 20);
            this.txtReturnBookCode.TabIndex = 10;
            this.txtReturnBookCode.Leave += new System.EventHandler(this.txtReturnBookCode_Leave);
            // 
            // txtReturnBookTitle
            // 
            this.txtReturnBookTitle.Location = new System.Drawing.Point(146, 118);
            this.txtReturnBookTitle.Name = "txtReturnBookTitle";
            this.txtReturnBookTitle.ReadOnly = true;
            this.txtReturnBookTitle.Size = new System.Drawing.Size(178, 20);
            this.txtReturnBookTitle.TabIndex = 11;
            // 
            // txtReturnMemberName
            // 
            this.txtReturnMemberName.Location = new System.Drawing.Point(146, 178);
            this.txtReturnMemberName.Name = "txtReturnMemberName";
            this.txtReturnMemberName.ReadOnly = true;
            this.txtReturnMemberName.Size = new System.Drawing.Size(178, 20);
            this.txtReturnMemberName.TabIndex = 13;
            // 
            // txtReturnMemberId
            // 
            this.txtReturnMemberId.Location = new System.Drawing.Point(146, 151);
            this.txtReturnMemberId.Name = "txtReturnMemberId";
            this.txtReturnMemberId.Size = new System.Drawing.Size(97, 20);
            this.txtReturnMemberId.TabIndex = 12;
            this.txtReturnMemberId.Leave += new System.EventHandler(this.txtReturnMemberId_Leave);
            // 
            // ReturnDueDatePicker
            // 
            this.ReturnDueDatePicker.Location = new System.Drawing.Point(146, 212);
            this.ReturnDueDatePicker.Name = "ReturnDueDatePicker";
            this.ReturnDueDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ReturnDueDatePicker.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Return Date";
            // 
            // ReturnDatePicker
            // 
            this.ReturnDatePicker.Location = new System.Drawing.Point(146, 256);
            this.ReturnDatePicker.Name = "ReturnDatePicker";
            this.ReturnDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ReturnDatePicker.TabIndex = 16;
            // 
            // txtReturnRemark
            // 
            this.txtReturnRemark.Location = new System.Drawing.Point(146, 296);
            this.txtReturnRemark.Multiline = true;
            this.txtReturnRemark.Name = "txtReturnRemark";
            this.txtReturnRemark.Size = new System.Drawing.Size(200, 92);
            this.txtReturnRemark.TabIndex = 17;
            // 
            // btnReturnSubmit
            // 
            this.btnReturnSubmit.Location = new System.Drawing.Point(148, 415);
            this.btnReturnSubmit.Name = "btnReturnSubmit";
            this.btnReturnSubmit.Size = new System.Drawing.Size(95, 34);
            this.btnReturnSubmit.TabIndex = 19;
            this.btnReturnSubmit.Text = "Submit";
            this.btnReturnSubmit.UseVisualStyleBackColor = true;
            this.btnReturnSubmit.Click += new System.EventHandler(this.btnReturnSubmit_Click);
            // 
            // lblTransactionIdError
            // 
            this.lblTransactionIdError.AutoSize = true;
            this.lblTransactionIdError.ForeColor = System.Drawing.Color.Red;
            this.lblTransactionIdError.Location = new System.Drawing.Point(147, 34);
            this.lblTransactionIdError.Name = "lblTransactionIdError";
            this.lblTransactionIdError.Size = new System.Drawing.Size(0, 13);
            this.lblTransactionIdError.TabIndex = 20;
            // 
            // BookReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.lblTransactionIdError);
            this.Controls.Add(this.btnReturnSubmit);
            this.Controls.Add(this.txtReturnRemark);
            this.Controls.Add(this.ReturnDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReturnDueDatePicker);
            this.Controls.Add(this.txtReturnMemberName);
            this.Controls.Add(this.txtReturnMemberId);
            this.Controls.Add(this.txtReturnBookTitle);
            this.Controls.Add(this.txtReturnBookCode);
            this.Controls.Add(this.txtReturnTransactionId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookReturnForm";
            this.Text = "Book Return Form";
            this.Load += new System.EventHandler(this.BookReturnForm_Load);
            this.Controls.SetChildIndex(this.ldlUseName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtReturnTransactionId, 0);
            this.Controls.SetChildIndex(this.txtReturnBookCode, 0);
            this.Controls.SetChildIndex(this.txtReturnBookTitle, 0);
            this.Controls.SetChildIndex(this.txtReturnMemberId, 0);
            this.Controls.SetChildIndex(this.txtReturnMemberName, 0);
            this.Controls.SetChildIndex(this.ReturnDueDatePicker, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.ReturnDatePicker, 0);
            this.Controls.SetChildIndex(this.txtReturnRemark, 0);
            this.Controls.SetChildIndex(this.btnReturnSubmit, 0);
            this.Controls.SetChildIndex(this.lblTransactionIdError, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReturnTransactionId;
        private System.Windows.Forms.TextBox txtReturnBookCode;
        private System.Windows.Forms.TextBox txtReturnBookTitle;
        private System.Windows.Forms.TextBox txtReturnMemberName;
        private System.Windows.Forms.TextBox txtReturnMemberId;
        private System.Windows.Forms.DateTimePicker ReturnDueDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ReturnDatePicker;
        private System.Windows.Forms.TextBox txtReturnRemark;
        private System.Windows.Forms.Button btnReturnSubmit;
        private System.Windows.Forms.Label lblTransactionIdError;
    }
}
