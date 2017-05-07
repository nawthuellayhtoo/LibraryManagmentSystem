namespace SA43Team2B
{
    partial class BorrowReceiptForm
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
            this.BorrowReceiptReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BorrowReceiptReportViewer
            // 
            this.BorrowReceiptReportViewer.ActiveViewIndex = -1;
            this.BorrowReceiptReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorrowReceiptReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.BorrowReceiptReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorrowReceiptReportViewer.Location = new System.Drawing.Point(0, 0);
            this.BorrowReceiptReportViewer.Name = "BorrowReceiptReportViewer";
            this.BorrowReceiptReportViewer.Size = new System.Drawing.Size(284, 263);
            this.BorrowReceiptReportViewer.TabIndex = 0;
            // 
            // BorrowReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.BorrowReceiptReportViewer);
            this.Name = "BorrowReceiptForm";
            this.Text = "Borrow Receipt Form";
            this.Load += new System.EventHandler(this.BorrowReceiptForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer BorrowReceiptReportViewer;
    }
}