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
    
    public partial class StudentCohortYear
    {
        public StudentCohortYear()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StudentUSI { get; set; }
        public int CohortYearTypeId { get; set; }
        public short SchoolYear { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StudentCohortYearIdentity { get; set; }
    
        public virtual CohortYearType CohortYearType { get; set; }
        public virtual SchoolYearType SchoolYearType { get; set; }
        public virtual Student Student { get; set; }
    }
}
