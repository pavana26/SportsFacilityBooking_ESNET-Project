using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BaseLibrary.ParentForms;
using BaseLibrary.Entities;

namespace SA46Team05A_Project.Forms
{
    public partial class FacilityCreateForm : BaseForm
    {
        SportsFacBookingEntities context;
        List<Facility> fList;
        public FacilityCreateForm(Form caller) : base(caller)
        {
            InitializeComponent();
            context = new SportsFacBookingEntities();
        }

        private void AddTimeslots(Facility f)
        {
            var timeslots = context.Availability.Select(x => x.Timeslot).Distinct().ToList();
            List<DateTime> todayTmr = new List<DateTime>();
            todayTmr.Add(DateTime.Today);
            todayTmr.Add(DateTime.Today.AddDays(1));
            foreach (DateTime day in todayTmr)
            {
                foreach (int timeslot in timeslots)
                {
                    Availability a = new Availability();
                    a.Facility = f;
                    a.AvailDate = day;
                    a.Timeslot = (short)timeslot;
                    a.Available = true;
                    context.Availability.Add(a);
                }
            }
       }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            fList = context.Facilities.ToList();

            Facility fNew = new Facility();
           
            fNew.FacilityID = FacilityID_TextBox.Text;
            fNew.FacilityName = FacilityName_TextBox.Text;

            var q1 = from x in context.Facilities where x.FacilityID == fNew.FacilityID select x;
            var q2 = from x in context.Facilities where x.FacilityName == fNew.FacilityName select x;
             
            if ((fNew.FacilityID == "") || (fNew.FacilityName == ""))
            {
                MessageBox.Show("Please enter data for both the fields.");
            }
            else if (q1.Count()>0)
            {
                MessageBox.Show("Facility ID already exists.");
            }
            else if(q2.Count()>0)
            {
                MessageBox.Show("Facility Name already exists.");
            }
            else
            { 
                fList.Add(fNew);
                context.Facilities.Add(fNew);
                AddTimeslots(fNew);
                context.SaveChanges();
                MessageBox.Show("New Facility created.");
                
                caller.Show();
                Dispose();
            }  
           
        }
    }
}
