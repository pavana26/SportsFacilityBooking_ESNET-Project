using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using BaseLibrary.ParentForms;
using BaseLibrary.Entities;


namespace SA46Team05A_Project.Forms
{
    public partial class BookingForm: BaseForm 
    {
        SportsFacBookingEntities context;
        BindingSource binding;
        HashSet<DataGridViewRow> selectedTimeslots;
        HashSet<DataGridViewRow> selectableTimeslots;
        HashSet<DataGridViewRow> availableTimeslots;

        public BookingForm(Form caller): base(caller)
        {
            InitializeComponent();
            context = new SportsFacBookingEntities();

            // Prepare Booking_DataGridView
            binding = new BindingSource();
            Base_DataGridView.AutoGenerateColumns = false;
            Base_DataGridView.DataSource = binding;
            selectedTimeslots = new HashSet<DataGridViewRow>();
            selectableTimeslots = new HashSet<DataGridViewRow>();
            availableTimeslots = new HashSet<DataGridViewRow>();

            // Fill Facility_Name_ComboBox
            List<Facility> facilities = context.Facilities.ToList();
            foreach (Facility facility in facilities)
            {
                Facility_ComboBox.Items.Add(facility.FacilityName);
            }
        }
        
        public BookingForm(Form caller, string facilityName): this(caller)
        {
            // Insert value from calling form
            Facility_ComboBox.Text = facilityName;
        }

        // Query Functions
        public List<Availability> GetTodaysAvailability(Facility facility)
        {
            return context.Availability.Where(
                x => x.AvailDate == DateTime.Today && x.Timeslot > DateTime.Today.Hour
                  && x.FacilityID == facility.FacilityID).ToList();
        }

        public List<Availability> GetTomorrowsAvailability(Facility facility)
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);
            return context.Availability.Where(
               x => x.AvailDate == tomorrow
                 && x.FacilityID == facility.FacilityID).ToList();
        }

        public HashSet<DataGridViewRow> GetAvailableTimeslotRows()
        {
            HashSet<DataGridViewRow> availableRows = new HashSet<DataGridViewRow>();
            foreach (DataGridViewRow row in Base_DataGridView.Rows)
            {
                if (!(bool)row.Cells["Booked_Column"].Value && (bool)row.Cells["Available_Column"].Value)
                    availableRows.Add(row);
            }
            return availableRows;
        }

        // Update Base_DataGridView
        public void ColorDataGridView()
        {
            selectedTimeslots.Clear();
            selectableTimeslots.Clear();

            foreach (DataGridViewRow row in Base_DataGridView.Rows)
            {
                
                if (availableTimeslots.Contains(row))
                    row.DefaultCellStyle.BackColor = Color.White;
                else if (!(bool)row.Cells["Available_Column"].Value)
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                else if ((bool)row.Cells["Booked_Column"].Value)
                    row.DefaultCellStyle.BackColor = Color.Pink;
            }
        }

        public void HighlightSelectableTimeslots(DataGridViewRow row)
        {
            selectableTimeslots.Clear();
            // Highlight rows above selected row
            int i = row.Index;
            while (i >= 0 
                   && availableTimeslots.Contains(Base_DataGridView.Rows[i]) 
                   && Base_DataGridView.Rows[i].Cells["Date_Column"].Value.ToString() == row.Cells["Date_Column"].Value.ToString())
            {
                Base_DataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                selectableTimeslots.Add(Base_DataGridView.Rows[i]);
                i--; 
            }

            // Highlight rows below selected row
            i = row.Index;
            while (i < Base_DataGridView.Rows.Count
                   && availableTimeslots.Contains(Base_DataGridView.Rows[i])
                   && Base_DataGridView.Rows[i].Cells["Date_Column"].Value.ToString() == row.Cells["Date_Column"].Value.ToString())
                {
                Base_DataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                selectableTimeslots.Add(Base_DataGridView.Rows[i]);
                i++; 
            }
        }

        public void FillInBetweenTimeslots()
        {
            int min = Base_DataGridView.Rows.Count;
            int max = 0;
            foreach (DataGridViewRow row in selectedTimeslots)
            {
                if (row.Index > max) max = row.Index;
                if (row.Index < min) min = row.Index;
            }

            for (int i = min; i <= max; i++)
            {
                selectedTimeslots.Add(Base_DataGridView.Rows[i]);
            }
        }

        public void ClearSelectedTimeslots()
        {
            foreach (DataGridViewRow row in selectedTimeslots)
                row.Cells["Booked_Column"].Value = false;

            binding.Clear();
            selectedTimeslots.Clear();
            selectableTimeslots.Clear();
            availableTimeslots.Clear();
        }

        // Event Handlers
        public void FilterValues_Changed(object sender, EventArgs e)
        {
            Status.Text = "";
            ClearSelectedTimeslots();

            if (Facility_ComboBox.Text != "")
            {
                List<Availability> availability = new List<Availability>();
                Facility facility = context.Facilities.Where(x =>
                    x.FacilityName == Facility_ComboBox.Text).First();
                
                // Today selected
                if (Today_CheckBox.Checked)
                    availability.AddRange(GetTodaysAvailability(facility));

                // Tomorrow selected
                if (Tomorrow_CheckBox.Checked)
                    availability.AddRange(GetTomorrowsAvailability(facility));

                binding.DataSource = availability;

                foreach (DataGridViewRow row in Base_DataGridView.Rows)
                {
                    var id = row.Cells["Member_ID_Column"].Value;
                    if (!(id is null))
                        row.Cells["Member_Name_Column"].Value = context.Members.First(x =>
                            x.MemberID == (int)id).MemberName;
                }
            }

            // Color DataGridView based on booked and available status
            if (Base_DataGridView.Rows.Count > 0)
                ColorDataGridView();

            // Mark down already booked slots
            availableTimeslots = GetAvailableTimeslotRows();
        }

        private void Base_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Status.Text = "";

            if (e.RowIndex >= 0 && e.ColumnIndex > 0 && 
                Base_DataGridView.Columns[e.ColumnIndex].Name == "Booked_Column")
            {
                DataGridViewRow row = Base_DataGridView.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells["Booked_Column"];

                // Update hashsets of selected timeslots
                if ((bool)cell.Value)
                    selectedTimeslots.Remove(row);
                else if (availableTimeslots.Contains(row))
                    selectedTimeslots.Add(row);

                if (selectedTimeslots.Count == 0)
                {
                    ColorDataGridView();
                }
                else if (selectedTimeslots.Count == 1)
                {
                    HighlightSelectableTimeslots(row);
                    Status.Text = "Please choose a timeslots highlighted in yellow";
                }
                else if (selectedTimeslots.Count >= 2 && selectableTimeslots.Contains(row))
                {
                    FillInBetweenTimeslots();
                }
                else if (selectedTimeslots.Count >= 2 && !selectableTimeslots.Contains(row))
                {
                    selectedTimeslots.Remove(row);
                    Status.Text = "Bookings must be in one continuous session. Please choose timeslots highlighted in yellow";
                }

                // Update Base_DataGridView based on hashsets
                foreach (DataGridViewRow r in availableTimeslots)
                {
                    r.Cells["Booked_Column"].Value = false;
                }

                foreach (DataGridViewRow r in selectedTimeslots)
                {
                    r.Cells["Booked_Column"].Value = true;
                }
            }
        }

        private void Booking_Button_Click(object sender, EventArgs e)
        {
            Status.Text = "";

            // Validate
            string MemberIDText = Member_ID_TextBox.Text;

            if (MemberIDText == "")
                Status.Text = "Please enter a Member ID";
            else if (!Int32.TryParse(MemberIDText, out int MemberID))
            {
                Status.Text = "Please enter a valid Member ID";
            }
            else
            {
                Member bookingMember = context.Members.First(x => x.MemberID == MemberID);

                if (bookingMember is null)
                    Status.Text = String.Format("Member ID {0} cannot be found. Please try another Member ID", MemberIDText);
                else if (selectedTimeslots.Count == 0)
                    Status.Text = "Please select a timeslot for a facility";
                else
                {
                    // Create transaction object
                    Transaction transaction = new Transaction();

                    transaction.StartTime = selectedTimeslots.Select(x =>
                        Int16.Parse(x.Cells["Timeslot_Column"].Value.ToString())).Min();
                    transaction.EndTime = (short)(selectedTimeslots.Select(x =>
                        Int16.Parse(x.Cells["Timeslot_Column"].Value.ToString())).Max() + 1);

                    transaction.Facility = context.Facilities.First(x => x.FacilityName == Facility_ComboBox.Text);
                    transaction.Member = bookingMember;
                    transaction.BookedDate = DateTime.Parse(selectedTimeslots.First().Cells["Date_Column"].Value.ToString());

                    context.Transactions.Add(transaction);
                    context.SaveChanges();

                    // Update availability object
                    foreach (DataGridViewRow row in selectedTimeslots)
                    {
                        short startTime = Int16.Parse(row.Cells["Timeslot_Column"].Value.ToString());
                        DateTime date = DateTime.Parse(row.Cells["Date_Column"].Value.ToString());
                        Availability timeslot = context.Availability.First(
                            x => x.Facility.FacilityName == Facility_ComboBox.Text
                              && x.Timeslot == startTime
                              && x.AvailDate == date);
                        timeslot.Transaction = transaction;
                        timeslot.Member = bookingMember;
                        timeslot.Booked = true;
                    }
                    context.SaveChanges();

                    DialogResult checkReceipt = MessageBox.Show("Booking has been made, would you like to see the receipt?", "Check receipt?", MessageBoxButtons.YesNo);
                    if (checkReceipt == DialogResult.Yes)
                    {
                        BookingReceiptForm f = new BookingReceiptForm(transaction.TransactionID);
                        f.Show();
                    }
                    Dispose();                    
                }
            }
        }

        private void Member_Query_Button_Click(object sender, EventArgs e)
        {
            MemberQueryForm f = new MemberQueryForm(this, Member_ID_TextBox, Member_Name_TextBox);
            f.ShowDialog();
        }
    }
}
