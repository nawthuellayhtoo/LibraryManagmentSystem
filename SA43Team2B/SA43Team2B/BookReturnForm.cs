using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace SA43Team2B
{
    public partial class BookReturnForm : SA43Team2B.BaseForm
    {
        private Sa43Team2bDBEntities context;
        private List<Book> bookList;
        private List<Member> memberList;
        private List<Transaction> tranList;
        private Member member;
        private Book book;
        private Transaction trans;
        private int bookId;
        private int memberId;
        private int tranId;
        private const string statusReturn = "in";
        public BookReturnForm()
        {
            InitializeComponent();
        }
        private void BookReturnForm_Load(object sender, EventArgs e)
        {
            context = new Sa43Team2bDBEntities();
            InitializeData();
        }
        private void btnReturnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            BookSearchForm searchForm = new BookSearchForm();
            searchForm.Show();
            Close();
        }

        private void btnReturnSubmit_Click(object sender, EventArgs e)
        {
            if (tranId != 0 && txtReturnBookCode.Text == "" || txtReturnMemberId.Text == "")
            {
                txtReturnBookCode.Focus();
            }
            else
            {
                if (tranId==0)
                {
                    trans = context.Transactions.Where(x => x.BookCode == bookId && x.MemberID == memberId).FirstOrDefault();
                    if (trans == null)
                    {
                        MessageBox.Show("There is no transaction for this book and member!");
                    }
                    else
                    {
                        updateTransaction();

                    }
                }
                else
                {
                    updateTransaction();
                }
            }
        }
        private void updateTransaction()
        {
            tranId = trans.TransactionID;
            trans.MemberID = member.MemberID;
            trans.EmployeeID = "E001";
            trans.BookCode = book.BookCode;

            trans.DateDue = ReturnDueDatePicker.Value;
            trans.DateReturned = ReturnDatePicker.Value;
            trans.Remarks = txtReturnRemark.Text;
            trans.BookLoanStatus = statusReturn;
            book.BookAvailableCount = Convert.ToInt16(book.BookAvailableCount + 1);
            context.SaveChanges();
            MessageBox.Show("Return Successfully!");
            clear();
        }
        private void InitializeData()
        {
            bookList = context.Books.ToList();
            memberList = context.Members.ToList();
            tranList = context.Transactions.ToList();
         
            ReturnDueDatePicker.Enabled = false;
            ReturnDatePicker.Enabled = false;
        }

        private void txtReturnTransactionId_Leave(object sender, EventArgs e)
        {
            try
            {
                tranId = Convert.ToInt16(txtReturnTransactionId.Text);
            }
            catch (FormatException)
            {
                lblTransactionIdError.Text = "Invalid TransactionId";
            }
            trans = context.Transactions.Where(x => x.TransactionID == tranId).FirstOrDefault();
            if (trans == null)
            {
                clear();
                MessageBox.Show("No record for this transaction id!");
            }
            else
            {
                lblTransactionIdError.Text = "";
                ReturnDueDatePicker.Value = trans.DateDue;
                txtReturnBookCode.Text = trans.BookCode.ToString();
                book = context.Books.Where(x => x.BookCode == trans.BookCode).FirstOrDefault();
                txtReturnBookTitle.Text = book.BookTitle;

                txtReturnMemberId.Text = trans.MemberID.ToString();
                member = context.Members.Where(x => x.MemberID == trans.MemberID).FirstOrDefault();
                txtReturnMemberName.Text = member.MemberName;
                txtReturnRemark.Text = trans.Remarks;
            }
            
        }
        private void clear()
        {
            txtReturnTransactionId.Text = "";
            txtReturnMemberId.Text = "";
            txtReturnMemberName.Text = "";
            txtReturnBookCode.Text = "";
            txtReturnBookTitle.Text = "";
            txtReturnRemark.Text = "";
            lblTransactionIdError.Text = "";
        }

        private void txtReturnBookCode_Leave(object sender, EventArgs e)
        {
            if (txtReturnTransactionId.Text == "")
            {
                try
                {
                    bookId = Convert.ToInt16(txtReturnBookCode.Text);
                    book = context.Books.Where(x => x.BookCode == bookId).FirstOrDefault();
                    if (book == null)
                    {
                        MessageBox.Show("No book for this code! Please Fill again!");
                        txtReturnBookCode.Text = "";
                    }
                    else
                    {
                        txtReturnBookTitle.Text = book.BookTitle.ToString();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid BookId!");
                    txtReturnBookCode.Text = "";
                }
            }
        }

        private void txtReturnMemberId_Leave(object sender, EventArgs e)
        {
            try
            {
                memberId = Convert.ToInt16(txtReturnMemberId.Text);
                member = context.Members.Where(y => y.MemberID == memberId).FirstOrDefault();
                if (member == null)
                {
                    MessageBox.Show("Member code is wrong!");
                    txtReturnMemberId.Text = "";
                }
                else
                {
                    txtReturnMemberName.Text = member.MemberName.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid MemberId!");
                txtReturnMemberId.Text = "";
            }

            if (tranId != 0 && txtReturnBookCode.Text == "" || txtReturnMemberId.Text == "")
            {
                txtReturnBookCode.Focus();
            }
            else
            {
                if (tranId == 0)
                {
                     trans = context.Transactions.Where(x => x.BookCode == bookId && x.MemberID==memberId).FirstOrDefault();
                    if (trans==null)
                    {
                        MessageBox.Show("Database record error!");
                    }else
                    {
                        tranId = trans.TransactionID;
                        ReturnDueDatePicker.Value = trans.DateDue;
                    }
                }
            }
        }
    }
}
