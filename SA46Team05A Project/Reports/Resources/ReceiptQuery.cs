using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SA46Team05A_Project.Reports;
using SA46Team05A_Project.Reports.Resources;

namespace SA46Team05A_Project
{
    class ReceiptQuery
    {

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=SA46Team05A Database;Integrated Security=SSPI");

        public DataSet Booking_Receipt(int transID)

        {

            SqlCommand com = new SqlCommand("select t.TransactionID, f.FacilityName, m.MemberName, t.TransDate, t.StartTime, t.Endtime from Transactions t, Facilities f, Members m where t.TransactionID = @Trans_id and t.FacilityID = f.FacilityID and t.MemberID = m.MemberID;", con);


            SqlDataAdapter da = new SqlDataAdapter(com);

            DataSet ds = new DataSet();
            com.Parameters.AddWithValue("@Trans_id", transID);
            da.Fill(ds);

            return ds;

        }
    }
}
