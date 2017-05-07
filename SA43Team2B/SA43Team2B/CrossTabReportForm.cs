using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks; 

namespace SA43Team2B
{
    public partial class CrossTabReportForm : SA43Team2B.BaseForm
    {
        public CrossTabReportForm()
        {
            InitializeComponent();
        }

        private void crvCrossTab_Load(object sender, EventArgs e)
        {
            Sa43Team2bDBDataSet ds = new Sa43Team2bDBDataSet();
            Sa43Team2bDBDataSetTableAdapters.BooksTableAdapter da = new Sa43Team2bDBDataSetTableAdapters.BooksTableAdapter();
            Sa43Team2bDBDataSetTableAdapters.TransactionsTableAdapter da2 = new Sa43Team2bDBDataSetTableAdapters.TransactionsTableAdapter();
            da.Fill(ds.Books);
            da2.Fill(ds.Transactions);
            CrossTabReport ctr = new CrossTabReport();
            ctr.SetDataSource(ds);
            crvCrossTab.Height = 700;
            crvCrossTab.Width = 900;
            this.crvCrossTab.ReportSource = ctr;

            //Invoice invoice = new Invoice(); // instance of my rpt file
            //var ds = new DsBilling();  // DsBilling is mine XSD
            //var table2 = ds.Vendor;
            //var adapter2 = new VendorTableAdapter();
            //adapter2.Fill(table2);


            //var table = ds.Bill;
            //var adapter = new BillTableAdapter();
            //string name = cboCustReport.Text;
            //int month = int.Parse(cboRptFromMonth.SelectedItem.ToString());
            //int year = int.Parse(cboReportFromYear.SelectedItem.ToString());
            //adapter.Fill(table, name, month, year);

            //ds.AcceptChanges();

            //invoice.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = invoice;
            //crystalReportViewer1.RefreshReport();





            //var qx = context.Books
            //    .Join(context.Transactions, a => a.BookCode, b => b.BookCode,
            //    (a, b) => new
            //    {
            //        BookLoanStatus = b.BookLoanStatus,
            //        DateIssue = b.DateIssue,
            //        BookGenere = a.BookGenere,
            //    })
            //    .Where(x => x.BookLoanStatus == "OUT")
            //    .GroupBy(x => x.DateIssue)
            //    .Select(x => new { x.Key });

            //var qy = context.Books
            //    .Join(context.Transactions, a => a.BookCode, b => b.BookCode,
            //    (a, b) => new
            //    {
            //         BookLoanStatus = b.BookLoanStatus,
            //         DateIssue = b.DateIssue,
            //         BookGenere = a.BookGenere,
            //    })
            //    .Where(x => x.BookLoanStatus == "OUT")
            //    .GroupBy(x => x.BookGenere)
            //    .Select(x => new
            //    {
            //         x.Key
            //    });

            //CrossTabReport ctr = new CrossTabReport();
            //ctr.SetDataSource(qx);
            //ctr.SetDataSource(qy);
            //crvCrossTab.ReportSource = ctr;

            //var qT = context.Transactions
            //    .Where(x => x.BookLoanStatus == "OUT")
            //    .GroupBy(x => x.DateIssue)
            //    .Select(y => new { y.Key });

            //report lob = new report();
            //lob.setdatasource(q.ToList());
            //crystalreportviewer1.reportsource=lob;
            //CrossTabReport ctr = new CrossTabReport();
            //ctr.SetDataSource(context.Books);
            //ctr.SetDataSource(context.Transactions);
        }

        private void CrossTabReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
