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
    public partial class Facility_Query_Form : BaseForm
    {
        SportsFacBookingEntities context = new SportsFacBookingEntities();
        public Facility_Query_Form(Form Caller):base(Caller)
        {
           //SportsFacBookingEntities context = new SportsFacBookingEntities();
            InitializeComponent();
            List<string> facilites = context.Facilities.Select(x => x.FacilityName).ToList();
            foreach (string facility in facilites)
                FacilityQuery_FacilityName_ComboBox.Items.Add(facility);
        }

        private void FacilityQuery_Form_Next_Button_Click(object sender, EventArgs e)
        {
            //SportsFacBookingEntities context = new SportsFacBookingEntities();
            var q = from x in context.Facilities
                    where x.FacilityName== FacilityQuery_FacilityName_ComboBox.Text select x;
            Facility fc = q.First();
            Facility_Edit_Form editform= new Facility_Edit_Form(this, fc);
            editform.Show();
        }
    }
}
