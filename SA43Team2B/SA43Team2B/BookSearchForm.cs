using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA43Team2B
{
    public partial class BookSearchForm : SA43Team2B.BaseForm
    {
        List<Book> cLst;
        
        Sa43Team2bDBEntities context;

        public BookSearchForm()
        {
            InitializeComponent();
        }

        

        
        private void Form1_Load(object sender, EventArgs e)
        {
            context = new Sa43Team2bDBEntities();
            cLst = context.Books.ToList();
        }
        private void button2_Click(object sender, EventArgs e) //search

        {
            toolStripStatusLabel1.Text = "";
            try
            {

                if (radioBookCode.Checked)
                {
                    var input = Convert.ToInt16(txtSearch.Text);
                    GridSearchResult.DataSource = context.Books.Where(x => x.BookCode == input).Select(x => new { x.BookCode, x.BookTitle, x.BookAuthor, x.BookGenere, x.BookPublisher, x.BookEdition, x.BookTotalCount, x.BookAvailableCount }).ToList();
                }
                else if (radioBookTitle.Checked)
                {
                    GridSearchResult.DataSource = context.Books.Where(x => x.BookTitle.Contains(txtSearch.Text)).Select(x => new { x.BookCode, x.BookTitle, x.BookAuthor, x.BookGenere, x.BookPublisher, x.BookEdition, x.BookTotalCount, x.BookAvailableCount }).ToList();

                }
                else if (radioBookAuthor.Checked)
                {
                    GridSearchResult.DataSource = context.Books.Where(x => x.BookAuthor.Contains(txtSearch.Text)).Select(x => new { x.BookCode, x.BookTitle, x.BookAuthor, x.BookGenere, x.BookPublisher, x.BookEdition, x.BookTotalCount, x.BookAvailableCount }).ToList();

                }
                else if (radioBookGenre.Checked)
                {
                    GridSearchResult.DataSource = context.Books.Where(x => x.BookGenere.Contains(txtSearch.Text)).Select(x => new { x.BookCode, x.BookTitle, x.BookAuthor, x.BookGenere, x.BookPublisher, x.BookEdition, x.BookTotalCount, x.BookAvailableCount }).ToList();

                }


                GridSearchResult.Columns[0].HeaderText = "Code";
                GridSearchResult.Columns[1].HeaderText = "Title";
                GridSearchResult.Columns[2].HeaderText = "Author";
                GridSearchResult.Columns[3].HeaderText = "Genre";
                GridSearchResult.Columns[4].HeaderText = "Publisher";
                GridSearchResult.Columns[5].HeaderText = "Edition";
                GridSearchResult.Columns[6].HeaderText = "Total Stock";
                GridSearchResult.Columns[7].HeaderText = "Available Stock";

                if (GridSearchResult.Rows.Count != 0)
                {
                    toolStripStatusLabel1.Text = "Search Successful";
                }

                else
                {
                    toolStripStatusLabel1.Text = "No Search Found";
                }
            }

            catch(Exception)
            {
                toolStripStatusLabel1.Text = "Invalid Data";
            }
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            GridSearchResult.DataSource = null;
            GridSearchResult.Rows.Clear();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            try
            {
                int bookCode = Convert.ToInt16(GridSearchResult.CurrentRow.Cells[0].Value);
                Book b = context.Books.Where(x => x.BookCode == bookCode).FirstOrDefault();

                if (b == null)
                {
                    toolStripStatusLabel1.Text = "No book selected";
                }
                else
                {

                    if (b.BookAvailableCount > 0)
                    {
                        this.Hide();
                        BookLendingForm BLF = new BookLendingForm(bookCode);
                        BLF.Show();
                        //this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Book is not available");
                    }
                }
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "Error Occured. Try again";
            }

        }
            

        private void btnCheckAvailable_Click(object sender, EventArgs e)
          {
            toolStripStatusLabel1.Text = "";
            try
            {
                int bookCode = Convert.ToInt16(GridSearchResult.CurrentRow.Cells[0].Value);
                Book b = context.Books.Where(x => x.BookCode == bookCode).FirstOrDefault();
                if (b == null)
                {
                    toolStripStatusLabel1.Text = "No book selected";
                }
                else
                {
                    if (b.BookAvailableCount > 0)
                    {
                        MessageBox.Show("Book is available now");
                    }
                    else
                    {

                        Transaction transaction = context.Transactions.Where(x => x.BookCode == bookCode).First();
                        DateTime datedue2 = transaction.DateDue;

                        MessageBox.Show("Estimated Available date :" + datedue2.Day + "/" + datedue2.Month + "/" + datedue2.Year);
                    }
                }
            }
            catch(Exception)
            {
                toolStripStatusLabel1.Text = "No book selected";
            
            }

        }
    }

    
}


