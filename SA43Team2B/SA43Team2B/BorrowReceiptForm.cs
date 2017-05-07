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
    public partial class BorrowReceiptForm : Form
    {
        private CrystalReport1 report;
        public BorrowReceiptForm(CrystalReport1 report)
        {
            InitializeComponent();
            this.report = report;
        }
        private void BorrowReceiptForm_Load(object sender, EventArgs e)
        {
            showReceiptReport();
        }
        public void showReceiptReport()
        {
            BorrowReceiptReportViewer.ReportSource = report;
        }
    }
}
