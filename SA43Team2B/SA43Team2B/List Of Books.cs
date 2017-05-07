using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SA43Team2B
{
    public partial class ListOfBooks : SA43Team2B.BaseForm
    {
        Sa43Team2bDBEntities context;
        public ListOfBooks()
        {
            InitializeComponent();
        }
        
       

        private void ListOfBooks_Load(object sender, EventArgs e)
        {
                context = new Sa43Team2bDBEntities();
                var q = from x in context.Books select new { x.BookCode, x.BookTitle, x.BookGenere, x.BookAuthor,x.BookTotalCount,x.BookAvailableCount };
                Report lob = new Report();
                lob.SetDataSource(q.ToList());           
                crystalReportViewer1.Height = 700;
                crystalReportViewer1.Width = 900;
                crystalReportViewer1.ReportSource = lob;
            }
           }
        }
    

