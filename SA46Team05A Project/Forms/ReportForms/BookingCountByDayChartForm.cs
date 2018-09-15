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
using SA46Team05A_Project.Reports.Resources.DataSetCrossTabTableAdapters;

namespace SA46Team05A_Project.Forms
{
    public partial class BookingCountByDayChartForm : Form
    {
        public BookingCountByDayChartForm()
        {
            InitializeComponent();
        }

        private void FacilityBookingChartForm_Load(object sender, EventArgs e)
        {
            DataSetCrossTab dsCrossTab = new DataSetCrossTab();
            AvailabilityTableAdapter ta = new AvailabilityTableAdapter();

            ta.Fill(dsCrossTab.Availability);

            Reports.BookingCountByDayChart crChart = new Reports.BookingCountByDayChart();
            crChart.SetDataSource(dsCrossTab);
            crystalReportViewer1.ReportSource = crChart;
        }
    }
}
