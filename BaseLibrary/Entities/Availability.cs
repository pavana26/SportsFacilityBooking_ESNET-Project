//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaseLibrary.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Availability
    {
        public string FacilityID { get; set; }
        public System.DateTime AvailDate { get; set; }
        public short Timeslot { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<int> TransactionID { get; set; }
        public bool Booked { get; set; }
        public bool Available { get; set; }
    
        public virtual Facility Facility { get; set; }
        public virtual Member Member { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
