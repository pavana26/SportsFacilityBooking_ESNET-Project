using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BaseLibrary.Entities;
using BaseLibrary.ParentForms;

namespace SA46Team05A_Project.Forms
{
    public partial class BookingCancellationForm : BaseForm
    {
        SportsFacBookingEntities context;
        BindingSource transactionBinding;
        List<Transaction> transactions;

        public BookingCancellationForm(Form caller) : base(caller)
        {
            InitializeComponent();
            context = new SportsFacBookingEntities();

            // Prepare Search_DataGridView
            Transaction_DataGridView.AutoGenerateColumns = false;
            transactionBinding = new BindingSource();
            Transaction_DataGridView.DataSource = transactionBinding;
        }

        // Get Transactions
        private List<Transaction> GetTransactionsOfMember(Member m)
        {
            return context.Transactions.Where(
                x => x.MemberID == m.MemberID
                && x.BookedDate >= DateTime.Today
                && !x.Cancelled).ToList();
        }

        // Update Data Binding
        private void UpdateDataBinding()
        {
            transactionBinding.DataSource = transactions.Select(
                x => new {
                    x.TransactionID,
                    x.Facility.FacilityName,
                    x.BookedDate,
                    x.StartTime,
                    x.EndTime,
                    x.Cancelled
                }).ToList(); ;
        }
        
        // Event Handlers
        private void Member_Query_Button_Click(object sender, EventArgs e)
        {
            Status.Text = "";

            MemberQueryForm f = new MemberQueryForm(this, Member_ID_TextBox, Member_Name_TextBox);
            f.ShowDialog();
        }

        private void Find_Bookings_Click(object sender, EventArgs e)
        {
            Status.Text = "";

            if (Member_ID_TextBox.Text == "")
            {
                Status.Text = "Please enter a Member ID";
            }
            else
            {
                int memberID = Int32.Parse(Member_ID_TextBox.Text);
                Member member = context.Members.First(x => x.MemberID == memberID);
                if (member is null)
                {
                    Status.Text = String.Format("Member ID {0} is invalid", memberID);
                }
                else
                {
                    Member_Name_TextBox.Text = member.MemberName;
                    transactions = GetTransactionsOfMember(member);
                    UpdateDataBinding();
                    Status.Text = String.Format("{0} bookings found", transactionBinding.Count);
                }
            }
        }

        private void Transaction_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                transactions[e.RowIndex].Cancelled = !transactions[e.RowIndex].Cancelled;
                UpdateDataBinding();
            }
        }

        private void Cancel_Booking_Click(object sender, EventArgs e)
        {
            Status.Text = "";

            List<Availability> cancelledTimeslots = new List<Availability>();
            List<Transaction> cancelledTransactions = transactions.Where(x => x.Cancelled).ToList();

            foreach (Transaction transaction in cancelledTransactions)
            {
                int transactionID = transaction.TransactionID;
                cancelledTimeslots = context.Availability
                    .Where(x => x.TransactionID == transactionID).ToList();

                foreach (Availability timeslot in cancelledTimeslots)
                {
                    timeslot.Member = null;
                    timeslot.Transaction = null;
                    timeslot.Booked = false;
                }
                context.SaveChanges();
            }

            string status = String.Format("{0} bookings of {1} have been cancelled.", cancelledTransactions.Count(), transactions[0].Member.MemberName);
            MessageBox.Show(status);
            caller.Show();
            Dispose();
        }
    }
}
