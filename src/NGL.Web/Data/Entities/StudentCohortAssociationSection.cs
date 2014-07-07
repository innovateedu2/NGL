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
    
    public partial class StudentCohortAssociationSection
    {
        public StudentCohortAssociationSection()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StudentUSI { get; set; }
        public int EducationOrganizationId { get; set; }
        public string CohortIdentifier { get; set; }
        public System.DateTime BeginDate { get; set; }
        public int SchoolId { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string LocalCourseCode { get; set; }
        public int TermTypeId { get; set; }
        public short SchoolYear { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StudentCohortAssociationSectionIdentity { get; set; }
    
        public virtual Section Section { get; set; }
        public virtual StudentCohortAssociation StudentCohortAssociation { get; set; }
    }
}
