//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS_Desktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class CancelationReasons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CancelationReasons()
        {
            this.LeaveSubmissionTable = new HashSet<LeaveSubmissionTable>();
        }
    
        public int id { get; set; }
        public string reason { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveSubmissionTable> LeaveSubmissionTable { get; set; }
    }
}