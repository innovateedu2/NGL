//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NGL.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class RestraintEventReason
    {
        public RestraintEventReason()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StudentUSI { get; set; }
        public int SchoolId { get; set; }
        public string RestraintEventIdentifier { get; set; }
        public System.DateTime EventDate { get; set; }
        public int RestraintEventReasonTypeId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int RestraintEventReasonIdentity { get; set; }
    
        public virtual RestraintEvent RestraintEvent { get; set; }
        public virtual RestraintEventReasonType RestraintEventReasonType { get; set; }
    }
}
