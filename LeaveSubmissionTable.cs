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
    
    public partial class LeaveSubmissionTable
    {
        public int id { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<int> LeaveTypeId { get; set; }
        public Nullable<int> LeaveStatusId { get; set; }
        public Nullable<System.DateTime> SubmissionDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> TotalDays { get; set; }
        public string Comments { get; set; }
        public Nullable<int> CancelId { get; set; }
    
        public virtual CancelationReasons CancelationReasons { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual LeaveStatus LeaveStatus { get; set; }
        public virtual LeaveStatus LeaveStatus1 { get; set; }
    }
}
