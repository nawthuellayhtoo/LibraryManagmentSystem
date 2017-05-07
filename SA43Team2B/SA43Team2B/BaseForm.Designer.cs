namespace SA43Team2B
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lendBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainBookRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyLoansByGenreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LogouttoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ldlUseName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.memberToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.LogouttoolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(734, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.lendBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.maintainBookRecordsToolStripMenuItem});
            this.bookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.bookToolStripMenuItem.Text = "Books";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // lendBookToolStripMenuItem
            // 
            this.lendBookToolStripMenuItem.Name = "lendBookToolStripMenuItem";
            this.lendBookToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.lendBookToolStripMenuItem.Text = "Lend ";
            this.lendBookToolStripMenuItem.Click += new System.EventHandler(this.lendBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.returnBookToolStripMenuItem.Text = "Return ";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // maintainBookRecordsToolStripMenuItem
            // 
            this.maintainBookRecordsToolStripMenuItem.Name = "maintainBookRecordsToolStripMenuItem";
            this.maintainBookRecordsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.maintainBookRecordsToolStripMenuItem.Text = "Maintain Records";
            this.maintainBookRecordsToolStripMenuItem.Click += new System.EventHandler(this.maintainBookRecordsToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem});
            this.memberToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.memberToolStripMenuItem.Text = "Member";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.maintenanceToolStripMenuItem.Text = "Maintain Records";
            this.maintenanceToolStripMenuItem.Click += new System.EventHandler(this.maintenanceToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfBooksToolStripMenuItem,
            this.BookGenreToolStripMenuItem,
            this.dailyLoansByGenreToolStripMenuItem1});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.reportsToolStripMenuItem.Text = "Report";
            // 
            // listOfBooksToolStripMenuItem
            // 
            this.listOfBooksToolStripMenuItem.Name = "listOfBooksToolStripMenuItem";
            this.listOfBooksToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listOfBooksToolStripMenuItem.Text = "List of Books";
            this.listOfBooksToolStripMenuItem.Click += new System.EventHandler(this.listOfBooksToolStripMenuItem_Click);
            // 
            // BookGenreToolStripMenuItem
            // 
            this.BookGenreToolStripMenuItem.Name = "BookGenreToolStripMenuItem";
            this.BookGenreToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.BookGenreToolStripMenuItem.Text = "Book Breakdown by Genre";
            this.BookGenreToolStripMenuItem.Click += new System.EventHandler(this.dailyLoansByGenreToolStripMenuItem_Click);
            // 
            // dailyLoansByGenreToolStripMenuItem1
            // 
            this.dailyLoansByGenreToolStripMenuItem1.Name = "dailyLoansByGenreToolStripMenuItem1";
            this.dailyLoansByGenreToolStripMenuItem1.Size = new System.Drawing.Size(230, 22);
            this.dailyLoansByGenreToolStripMenuItem1.Text = "Daily Loans by Genre";
            this.dailyLoansByGenreToolStripMenuItem1.Click += new System.EventHandler(this.dailyLoansByGenreToolStripMenuItem1_Click);
            // 
            // LogouttoolStripMenuItem1
            // 
            this.LogouttoolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LogouttoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogouttoolStripMenuItem1.Name = "LogouttoolStripMenuItem1";
            this.LogouttoolStripMenuItem1.Size = new System.Drawing.Size(61, 21);
            this.LogouttoolStripMenuItem1.Text = "Logout";
            this.LogouttoolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ldlUseName
            // 
            this.ldlUseName.AutoSize = true;
            this.ldlUseName.BackColor = System.Drawing.Color.White;
            this.ldlUseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlUseName.Location = new System.Drawing.Point(613, 5);
            this.ldlUseName.Name = "ldlUseName";
            this.ldlUseName.Size = new System.Drawing.Size(45, 16);
            this.ldlUseName.TabIndex = 3;
            this.ldlUseName.Text = "label1";
            this.ldlUseName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.White;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(567, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(40, 16);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.ldlUseName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lendBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainBookRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BookGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyLoansByGenreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LogouttoolStripMenuItem1;
        private System.Windows.Forms.Label lblUser;
        protected System.Windows.Forms.Label ldlUseName;
    }
}