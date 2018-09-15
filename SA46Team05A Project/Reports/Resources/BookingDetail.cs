using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA46Team05A_Project
{
    class BookingDetail
    {
        public int TransactionID { get; set; }

        public string FacilityName { get; set; }

        public string MemberName { get; set; }

        public DateTime TransactionDate{ get; set; }

        public int StartTime{ get; set; }

        public int EndTime { get; set; }

    }
}
