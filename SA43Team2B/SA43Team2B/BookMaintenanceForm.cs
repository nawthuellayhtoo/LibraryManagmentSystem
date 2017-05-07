using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SA43Team2B
{
    public partial class BookMaintenanceForm : SA43Team2B.BaseForm
    {
        Sa43Team2bDBEntities context;
        List<Book> bList;
        Book b;
        int position;
        bool validCode, validTitle, validAuthor, validGenre, validPublisher, validEdition, validStock;

        public BookMaintenanceForm()
        {
            InitializeComponent();
            context = new Sa43Team2bDBEntities();
            bList = context.Books.ToList();
            b = context.Books.First();
            position = 0;
            validCode = true;
            validTitle = true;
            validAuthor = true;
            validGenre = true;
            validPublisher = true;
            validEdition = true;
            validStock = true;
        }

        private void populateTextBoxes()
        {
            if (radioBookCode.Checked)
            {
                for (int i = 0; i < bList.Count; i++)
                {
                   if (bList[i].BookCode == Convert.ToInt16(txtSearch.Text))
                    {
                        position = i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < bList.Count; i++)
                {
                    if (bList[i].BookTitle == txtSearch.Text)
                    {
                        position = i;
                        break;
                    }
                }
            }
            txtBookCode.Text = bList[position].BookCode.ToString();
            txtBookTitle.Text = bList[position].BookTitle;
            txtBookAuthor.Text = bList[position].BookAuthor;
            txtBookGenre.Text = bList[position].BookGenere;
            txtBookPublisher.Text = bList[position].BookPublisher;
            txtBookEdition.Text = bList[position].BookEdition;
            txtTotalStock.Text = bList[position].BookTotalCount.ToString();

        }

        private void retrieveTextBoxes()
        {
            try
            {
                bList[position].BookCode = Convert.ToInt16(txtBookCode.Text);
                bList[position].BookTitle = txtBookTitle.Text;
                bList[position].BookAuthor = txtBookAuthor.Text;
                bList[position].BookGenere = txtBookGenre.Text;
                bList[position].BookPublisher = txtBookPublisher.Text;
                bList[position].BookEdition = txtBookEdition.Text;
                bList[position].BookTotalCount = Convert.ToInt16(txtTotalStock.Text);
            }
            catch (Exception)
            {
                validCode = false;
                validTitle = false;
                validAuthor = false;
                validGenre = false;
                validPublisher = false;
                validEdition = false;
                validStock = false;
            }

        }

        private bool IsValidCode()
        {
            try
            {
                if (string.IsNullOrEmpty(txtBookCode.Text) || string.IsNullOrWhiteSpace(txtBookCode.Text))
                {
                    validCode = false;
                }

                if (Regex.IsMatch(txtBookCode.Text, @"(?i)^[a-z]+$"))
                {
                    validCode = false;
                }
            }
            catch (Exception)
            {
                validCode = false;
            }
            return validCode;
        }

        private bool IsValidTitle()
        {
            try
            {
                if (string.IsNullOrEmpty(txtBookTitle.Text))
                {
                    validTitle = false;
                }

            }
            catch (Exception)
            {
                validTitle = false;
            }
            return validTitle;
        }

        private bool IsValidAuthor()
        {
            try
            {
                if (string.IsNullOrEmpty(txtBookAuthor.Text))
                {
                    validAuthor = false;
                }

            }
            catch (Exception)
            {
                validAuthor = false;
            }
            return validAuthor;
        }

        private bool IsValidGenre()
        {
            try
            {
                if (string.IsNullOrEmpty(txtBookGenre.Text))
                {
                    validGenre = false;
                }

            }
            catch (Exception)
            {
                validGenre = false;
            }
            return validGenre;
        }

        private bool IsValidPublisher()
        {
            try
            {
                if (string.IsNullOrEmpty(txtBookPublisher.Text))
                {
                    validPublisher = false;
                }

            }
            catch (Exception)
            {
                validPublisher = false;
            }
            return validPublisher;
        }

       

        private bool IsValidEdition()
        {
            try
            {
                if (string.IsNullOrEmpty(txtBookEdition.Text))
                {
                    validEdition = false;
                }

            }
            catch (Exception)
            {
                validEdition = false;
            }
            return validEdition;
        }

        private bool IsValidStock()
        {
            try
            {
                if (string.IsNullOrEmpty(txtTotalStock.Text) || string.IsNullOrWhiteSpace(txtTotalStock.Text))
                {
                    validStock = false;
                }

                if (Regex.IsMatch(txtTotalStock.Text, @"(?i)^[a-z]+$"))
                {
                    validStock = false;
                }
            }
            catch (Exception)
            {
                validStock = false;
            }
            return validStock;
        }

        private void gridBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (gridBookList.SelectedRows.Count > 0)
            {
                string vBookCode, vBookTitle, vBookGenre, vBookAuthor;

                vBookCode = gridBookList.CurrentRow.Cells[0].Value + string.Empty;
                vBookTitle = gridBookList.CurrentRow.Cells[1].Value + string.Empty;
                vBookGenre = gridBookList.CurrentRow.Cells[2].Value + string.Empty;
                vBookAuthor = gridBookList.CurrentRow.Cells[3].Value + string.Empty;

                txtBookCode.Text = vBookCode;
                txtBookTitle.Text = vBookTitle;
                txtBookGenre.Text = vBookGenre;
                txtBookAuthor.Text = vBookAuthor;

                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnInsert.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            position = bList.Count - 1;

            b = new Book();

            IsValidTitle();
            IsValidAuthor();
            IsValidGenre();
            IsValidPublisher();
            IsValidStock();

            if (validTitle == false || validAuthor == false || validGenre == false || validPublisher == false || validStock == false)
            {
                lblStatusStrip.Text = "Invalid Input! Please try again!";
            }
            else
            {
                b.BookCode = (bList[position].BookCode + 1);
                txtBookCode.Text = b.BookCode.ToString();
                b.BookTitle = txtBookTitle.Text;
                b.BookAuthor = txtBookAuthor.Text;
                b.BookGenere = txtBookGenre.Text;
                b.BookPublisher = txtBookPublisher.Text;
                b.BookEdition = txtBookEdition.Text;
                b.BookTotalCount = Convert.ToInt16(txtTotalStock.Text);
                b.BookAvailableCount = Convert.ToInt16(txtTotalStock.Text);
                context.Books.Add(b);
                context.SaveChanges();
                lblStatusStrip.Text = "New book created!";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            retrieveTextBoxes();

            IsValidTitle();
            IsValidAuthor();
            IsValidGenre();
            IsValidPublisher();
            IsValidStock();

            if (validTitle == false || validAuthor == false || validGenre == false || validPublisher == false || validStock == false)
            {
                lblStatusStrip.Text = "Invalid Input! Please try again!";
            }
            else
            {
                context.SaveChanges();
                lblStatusStrip.Text = "Book updated!";
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (radioBookCode.Checked == true)
            {
                for (int i = 0; i < bList.Count; i++)
                {
                    if (bList[i].BookCode == Convert.ToInt16(txtSearch.Text))
                    {
                        position = i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < bList.Count; i++)
                {
                    if (bList[i].BookTitle == txtSearch.Text)
                    {
                        position = i;
                        break;
                    }
                }

            }
           
            context.Books.Remove(bList[position]);
            context.SaveChanges();
            lblStatusStrip.Text = "Book deleted!";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (radioBookCode.Checked)
            {
                populateTextBoxes();
                IsValidCode();
                lblStatusStrip.Text = "";

                if (validCode == false)
                {
                    lblStatusStrip.Text = "Invalid Book Code! Please try again!";
                }
                else
                {
                    var input = Convert.ToInt16(txtSearch.Text);
                    gridBookList.DataSource = context.Books.Where(x => x.BookCode == input).Select(x => new { x.BookCode, x.BookTitle, x.BookAuthor, x.BookGenere, x.BookPublisher, x.BookEdition, x.BookTotalCount, x.BookAvailableCount }).ToList();
                }

            }
            else if (radioBookTitle.Checked)
            {
                gridBookList.DataSource = context.Books.Where(x => x.BookTitle.Contains(txtSearch.Text)).Select(x => new { x.BookCode, x.BookTitle, x.BookAuthor, x.BookGenere, x.BookPublisher, x.BookEdition, x.BookTotalCount, x.BookAvailableCount }).ToList();

                if (gridBookList.Rows.Count == 0)
                {
                    lblStatusStrip.Text = "No Results Found";
                }
            }

            gridBookList.Columns[0].HeaderText = "Code";
            gridBookList.Columns[1].HeaderText = "Title";
            gridBookList.Columns[2].HeaderText = "Author";
            gridBookList.Columns[3].HeaderText = "Genre";
            gridBookList.Columns[4].HeaderText = "Publisher";
            gridBookList.Columns[5].HeaderText = "Edition";
            gridBookList.Columns[6].HeaderText = "Total Stock";
            gridBookList.Columns[7].HeaderText = "Available Stock";
            btnDelete.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void BookMaintenanceForm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void clear()
        {
            txtBookCode.Text = "";
            txtBookTitle.Text = "";
            txtBookAuthor.Text = "";
            txtBookEdition.Text = "";
            txtBookGenre.Text = ""; 
            txtBookPublisher.Text = "";
            txtTotalStock.Text = ""; 
            btnInsert.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
