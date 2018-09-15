using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team05A_Project.Forms
{
    public partial class AppMainMenu : Form
    {
        public AppMainMenu()
        {
            InitializeComponent();
        }

        private void Create_Member_Button_Click(object sender, EventArgs e)
        {
            MemberMaintenanceForm f = new MemberMaintenanceForm(this);
            f.Show();
        }

        private void Edit_Member_Button_Click(object sender, EventArgs e)
        {
            MemberQueryForm f = new MemberQueryForm(this);
            f.Show();
        }

        private void FacilityQueryForm_Button_Click(object sender, EventArgs e)
        {
            Facility_Query_Form f = new Facility_Query_Form(this);
            f.Show();
        }

        private void BookingCancellationForm_Button_Click(object sender, EventArgs e)
        {
            BookingCancellationForm f = new BookingCancellationForm(this);
            f.Show();
        }

        private void MemberQueryForm_Button_Click(object sender, EventArgs e)
        {
            MemberQueryForm f = new MemberQueryForm(this);
            f.Show();
        }

        private void BookingForm_Button_Click(object sender, EventArgs e)
        {
            BookingForm f = new BookingForm(this);
            f.Show();
        }

        private void CreateFacilityForm_Button_Click(object sender, EventArgs e)
        {
            FacilityCreateForm f = new FacilityCreateForm(this);
            f.Show();
        }

        private void BookingCountByDayChart_Button_Click(object sender, EventArgs e)
        {
            BookingCountByDayChartForm f = new BookingCountByDayChartForm();
            f.Show();
        }

        private void BookingCountByDayReport_Button_Click(object sender, EventArgs e)
        {
            BookingCountByDayReportForm f = new BookingCountByDayReportForm();
            f.Show();
        }

        private void TransactionReport_Button_Click(object sender, EventArgs e)
        {
            TransactionReportForm f = new TransactionReportForm();
            f.Show();
        }
    }
}
