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
    
    public partial class StateEducationAgencyAccountability
    {
        public StateEducationAgencyAccountability()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StateEducationAgencyId { get; set; }
        public short SchoolYear { get; set; }
        public Nullable<bool> CTEGraduationRateInclusion { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StateEducationAgencyAccountabilityIdentity { get; set; }
    
        public virtual SchoolYearType SchoolYearType { get; set; }
        public virtual StateEducationAgency StateEducationAgency { get; set; }
    }
}
