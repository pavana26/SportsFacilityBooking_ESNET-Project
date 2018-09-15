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

namespace SA46Team05A_Project
{
    public partial class BookingReceiptForm : Form
    {
        int transID;
        public BookingReceiptForm(int transID)
        {
            InitializeComponent();
            this.transID = transID;
        }

        private void BookingReceiptForm_Load(object sender, EventArgs e)
        {
            ReceiptQuery db = new ReceiptQuery();
            BookingDetail bookingDetail = new BookingDetail();
            DataSet ds = db.Booking_Receipt(transID);

            // Get values from query result
            bookingDetail.TransactionID = Convert.ToInt16(ds.Tables[0].Rows[0]["TransactionID"]);
            bookingDetail.FacilityName = ds.Tables[0].Rows[0]["FacilityName"].ToString();
            bookingDetail.MemberName = ds.Tables[0].Rows[0]["MemberName"].ToString();
            bookingDetail.TransactionDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["TransDate"]);
            bookingDetail.StartTime = Convert.ToInt16(ds.Tables[0].Rows[0]["StartTime"]);
            bookingDetail.EndTime = Convert.ToInt16(ds.Tables[0].Rows[0]["EndTime"]);

            // Fill receipt with values
            BookingReceipt br = new BookingReceipt();
            br.SetParameterValue("pTransactionID", bookingDetail.TransactionID);
            br.SetParameterValue("pMemberID", bookingDetail.MemberName);
            br.SetParameterValue("pFacilityID", bookingDetail.FacilityName);
            br.SetParameterValue("pTransactionDate", bookingDetail.TransactionDate);
            br.SetParameterValue("pStartTime", bookingDetail.StartTime);
            br.SetParameterValue("pEndTime", bookingDetail.EndTime);

            br.SetParameterValue("pTransactionID", bookingDetail.TransactionID);
            br.SetParameterValue("pMemberID", bookingDetail.MemberName);
            br.SetParameterValue("pFacilityID", bookingDetail.FacilityName);
            br.SetParameterValue("pTransactionDate", bookingDetail.TransactionDate);
            br.SetParameterValue("pStartTime", bookingDetail.StartTime);
            br.SetParameterValue("pEndTime", bookingDetail.EndTime);

            crystalReportViewer1.ReportSource = br;
        }
    }
}
