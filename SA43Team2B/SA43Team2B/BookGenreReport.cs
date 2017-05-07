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
    public partial class BookGenreReportForm : SA43Team2B.BaseForm
    {
        public BookGenreReportForm()
        {
            InitializeComponent();
        }

        private void BookGenreReportForm_Load(object sender, EventArgs e)
        {
            Sa43Team2bDBEntities context = new Sa43Team2bDBEntities();
             BookGenreReport br = new BookGenreReport();
             br.SetDataSource(context.Books);
            crystalReportViewer1.Height = 700;
            crystalReportViewer1.Width = 900;
            crystalReportViewer1.ReportSource = br;
        }

        
    }
}
