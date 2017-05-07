using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace SA43Team2B
{
    public partial class BookLendingForm : SA43Team2B.BaseForm
    {
        private Sa43Team2bDBEntities context;
        private List<Book> bookList;
        private List<Member> memberList;
        private List<Transaction> tranList;
        private Member member;
        private Book book;
        private int bookId;
        private int memberId;
        private const string statusLend = "out";
        private List<int> borrowTransList;
        public BookLendingForm()
        {
            InitializeComponent();
        }
        public BookLendingForm(int bookId)
        {
            InitializeComponent();
            this.bookId = bookId;
        }

        private void BookLendingForm_Load(object sender, EventArgs e)
        {
            context = new Sa43Team2bDBEntities();
            borrowTransList = new List<int>();
            InitializeData();
        }

        private void btnLendCancel_Click(object sender, EventArgs e)
        {
            Hide();
            BookSearchForm searchForm = new BookSearchForm();
            searchForm.Show();
            Close();
        }

        private void btnLendSubmit_Click(object sender, EventArgs e)
        {
            if (txtLendingBookCode.Text=="" || txtLendingMemberId.Text=="")
            {
                txtLendingBookCode.Focus();
                lblStatus.Text = "Please fill MemberId!";
            }
            else { 
            DateTime issueDate = IssueDatePicker.Value.Date;
            DateTime dueDate = DueDatePicker.Value.Date;
            string remarks = txtLendingRemark.Text;

            if (book.BookAvailableCount <= 0)
            {
                MessageBox.Show("Book copies are not enough in the system!");
                clear();
            }
            else
            {
                    try
                    {

                   
                Transaction tran = new Transaction();
                int index = tranList.Count - 1;
                tran.TransactionID = (tranList[index].TransactionID) + 1;
                tran.MemberID = member.MemberID;
                tran.EmployeeID = "E001";
                tran.BookCode = book.BookCode;
                tran.DateIssue = issueDate;
                tran.DateDue = dueDate;
                tran.BookLoanStatus = statusLend;
                tran.Remarks = remarks;

                book.BookAvailableCount = Convert.ToInt16(book.BookAvailableCount - 1);
                context.Transactions.Add(tran);
                context.SaveChanges();
                MessageBox.Show("Transcation recorded!");
                borrowTransList.Add(tran.TransactionID);
                btnPrintReceipt.Enabled = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Not Successfully update");
                    }

                }
            }

        }

        private void txtLendingBookCode_Leave(object sender, EventArgs e)
        {
            if (IsvalidBookId())
            {
                book = context.Books.Where(x => x.BookCode == bookId).FirstOrDefault();
                if (book == null)
                {
                    MessageBox.Show("No book for this code! Please Fill again!");
                    txtLendingBookCode.Text = "";
                }
                else
                {
                    txtLendingBookTitle.Text = book.BookTitle.ToString();
                }
                
            }
        }
        private void txtLendingMemberId_Leave(object sender, EventArgs e)
        {
            if (IsvalidMemberId())
            {
                member = context.Members.Where(y => y.MemberID == memberId).FirstOrDefault();
                if (member == null)
                {
                    MessageBox.Show("Member code is wrong!");
                    txtLendingMemberId.Text = "";
                }
                else
                {
                    txtLendingMemberName.Text = member.MemberName.ToString();
                }
                
            }
        }

        private void btnLendMore_Click(object sender, EventArgs e)
        {
            clear();
            txtLendingBookCode.Focus();
        }
        private void clear()
        {
            txtLendingMemberId.Text = "";
            txtLendingMemberName.Text = "";
            txtLendingBookTitle.Text = "";
            txtLendingBookCode.Text = "";
            txtLendingRemark.Text = "";
            InitializeData();
        }
        private void InitializeData()
        {
            bookList = context.Books.ToList();
            memberList = context.Members.ToList();
            tranList = context.Transactions.ToList();

            if (bookId!=0)
            {
                txtLendingBookCode.Text = Convert.ToString(bookId);
            }
            IssueDatePicker.Value = DateTime.Now;
            IssueDatePicker.Enabled = false;
            btnPrintReceipt.Enabled = false;

            DueDatePicker.Value = DateTime.Now.AddDays(3);
        }
        private bool IsvalidBookId()
        {
            bool isValid = true;
            try
            {
                bookId = Convert.ToInt16(txtLendingBookCode.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid BookId!");
                isValid = false;
            }
           
            return isValid;
        }
        private bool IsvalidMemberId()
        {
            bool isValid = true;
            try
            {
              memberId = Convert.ToInt16(txtLendingMemberId.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid MemberId!");
                isValid = false;
            }
            return isValid;
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {

            ReceiptReportDataSet receiptDataSet = new ReceiptReportDataSet();
            ReceiptReportDataSetTableAdapters.DataTable1TableAdapter adapter = new ReceiptReportDataSetTableAdapters.DataTable1TableAdapter();
          
            adapter.Fill(receiptDataSet.DataTable1);

            CrystalReport1 receiptReport = new CrystalReport1();
            receiptReport.SetDataSource(receiptDataSet);

            BorrowReceiptForm receiptForm = new BorrowReceiptForm(receiptReport);
            receiptForm.Show();
            btnPrintReceipt.Enabled = false;
        }
    }
}

