namespace SA43Team2B
{
    partial class CrossTabReportForm
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
            this.crvCrossTab = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCrossTab
            // 
            this.crvCrossTab.ActiveViewIndex = -1;
            this.crvCrossTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCrossTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCrossTab.Location = new System.Drawing.Point(0, 28);
            this.crvCrossTab.Name = "crvCrossTab";
            this.crvCrossTab.Size = new System.Drawing.Size(734, 434);
            this.crvCrossTab.TabIndex = 5;
            this.crvCrossTab.Load += new System.EventHandler(this.crvCrossTab_Load);
            // 
            // CrossTabReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.crvCrossTab);
            this.Name = "CrossTabReportForm";
            this.Text = "Daily Book Loans by Genre";
            this.Load += new System.EventHandler(this.CrossTabReportForm_Load);
            this.Controls.SetChildIndex(this.ldlUseName, 0);
            this.Controls.SetChildIndex(this.crvCrossTab, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCrossTab;
    }
}
