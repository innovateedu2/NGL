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
    
    public partial class InterventionStaff
    {
        public InterventionStaff()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public string InterventionIdentificationCode { get; set; }
        public int EducationOrganizationId { get; set; }
        public int StaffUSI { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int InterventionStaffIdentity { get; set; }
    
        public virtual Intervention Intervention { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
