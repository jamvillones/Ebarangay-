//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Barangay
{
    using System;
    using System.Collections.Generic;
    
    public partial class Complaint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Complaint()
        {
            this.CitizenToComplaints = new HashSet<CitizenToComplaint>();
        }
    
        public int ID { get; set; }
        public string Narrative { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateHappened { get; set; }
        public Nullable<System.DateTime> DateIssued { get; set; }
        public Nullable<System.DateTime> SettlementDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CitizenToComplaint> CitizenToComplaints { get; set; }
    }
}
