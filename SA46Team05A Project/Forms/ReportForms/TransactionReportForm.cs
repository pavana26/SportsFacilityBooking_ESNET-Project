using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SA46Team05A_Project.Reports;
using SA46Team05A_Project.Reports.Resources;
using SA46Team05A_Project.Reports.Resources.DataSetTransReportTableAdapters;

namespace SA46Team05A_Project
{
    public partial class TransactionReportForm : Form
    {
        public TransactionReportForm()
        {
            InitializeComponent();
        }

        private void IssueTransactionReportForm_Load(object sender, EventArgs e)
        {
            DataSetTransReport ds = new DataSetTransReport();
            TransactionsTableAdapter td = new TransactionsTableAdapter();

            td.Fill(ds.Transactions);

            TransactionReport cr = new TransactionReport();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
