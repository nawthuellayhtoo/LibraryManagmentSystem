using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SA43Team2B
{
    public partial class BaseForm : Form
    {
        
        public BaseForm()
        {
            InitializeComponent();
            ldlUseName.Text = LoginForm.UserName;
        }


        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            BookSearchForm bsf = new BookSearchForm();
            this.Hide();
            bsf.ShowDialog();
            searchToolStripMenuItem.Enabled = false;
            this.Dispose();
        }

        private void lendBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
          BookLendingForm blf = new BookLendingForm();
            this.Hide();
            blf.ShowDialog();
            this.Dispose();
            //this.Close();
           
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReturnForm brf = new BookReturnForm();
            this.Hide();
            brf.ShowDialog();
            this.Dispose();
            //this.Close();

        }

        private void maintainBookRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookMaintenanceForm bmf = new BookMaintenanceForm();
            this.Hide();
            bmf.ShowDialog();
            this.Dispose();
            //this.Close();
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberMaintenanceForm mmf = new MemberMaintenanceForm();
            this.Hide();
            mmf.ShowDialog();
            this.Dispose();
            //this.Close();
            
        }

        private void listOfBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ListOfBooks rf = new ListOfBooks();
            rf.Width = 1000;
            rf.Height = 750;
            this.Hide();
            rf.ShowDialog();
            this.Dispose();
            this.Close();
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.ShowDialog();
            this.Dispose();
            this.Close();

            
        }

        private void dailyLoansByGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           BookGenreReportForm bg = new BookGenreReportForm();
            bg.Width = 1000;
            bg.Height = 750;
            this.Hide();
            bg.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void dailyLoansByGenreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrossTabReportForm rf = new CrossTabReportForm();
            rf.Width = 1000;
            rf.Height = 750;
            this.Hide();
            rf.ShowDialog();
            this.Dispose();
            this.Close();
        }
    }
}
