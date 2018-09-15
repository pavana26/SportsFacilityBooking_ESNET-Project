using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BaseLibrary.Entities;
using BaseLibrary.ParentForms;

namespace SA46Team05A_Project.Forms
{
    public partial class Facility_Edit_Form : BaseForm
    {
        Facility facility;
        bool todayNotAvailable;
        bool tomorrowNotAvailable;
        SportsFacBookingEntities context;
        DateTime tmr = DateTime.Today.AddDays(1);

        public Facility_Edit_Form(Form caller, Facility facility):base(caller)
        {
            InitializeComponent();
            
            this.facility = facility;
            FacilityEditForm_Auto_Label.Text = facility.FacilityName;
            context = new SportsFacBookingEntities();

            todayNotAvailable = CheckAvailabilityByDate(DateTime.Today);
            Not_In_Use_Today_CheckBox.Checked = todayNotAvailable;
            
            tomorrowNotAvailable = CheckAvailabilityByDate(tmr);
            Not_In_Use_Tmr_CheckBox.Checked = tomorrowNotAvailable;
        }

        private bool CheckAvailabilityByDate(DateTime date)
        {
            List<Availability> availability = context.Availability.Where(
                x => x.Available == false
                && x.AvailDate == date
                && x.Facility.FacilityName == facility.FacilityName)
                .ToList();
            if (availability.Count == 0)
                return false;
            else
                return true;
        }

        private void ToggleAvailabityByDateAndFacility(DateTime dt, Facility facility, bool available)
        {
            List<Availability> availability = context.Availability.Where(x => 
                x.AvailDate == dt 
                && x.Facility.FacilityName == facility.FacilityName)
                .ToList();
            foreach (Availability a in availability)
                a.Available = available;
            context.SaveChanges();
        }


        private void FacilityEditForm_Confirm_Button_Click(object sender, EventArgs e)
        {
            ToggleAvailabityByDateAndFacility(DateTime.Today, facility, !Not_In_Use_Today_CheckBox.Checked);
            ToggleAvailabityByDateAndFacility(DateTime.Today.AddDays(1), facility, !Not_In_Use_Tmr_CheckBox.Checked);

            if (Not_In_Use_Today_CheckBox.Checked != todayNotAvailable
                || Not_In_Use_Tmr_CheckBox.Checked != tomorrowNotAvailable)
            {
                MessageBox.Show("Changes have been saved.");
            }
            else
            {
                DialogResult result = MessageBox.Show
                    ("No changes have been made, do you wish to change something?", 
                    "No changes made", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    Dispose(); 
            }
        }
    }
}
