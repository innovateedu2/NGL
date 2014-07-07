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
    
    public partial class GraduationPlanCreditsBySubject
    {
        public GraduationPlanCreditsBySubject()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int EducationOrganizationId { get; set; }
        public int AcademicSubjectDescriptorId { get; set; }
        public decimal Credit { get; set; }
        public Nullable<int> CreditTypeId { get; set; }
        public Nullable<decimal> CreditConversion { get; set; }
        public int GraduationPlanTypeDescriptorId { get; set; }
        public short GraduationSchoolYear { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int GraduationPlanCreditsBySubjectIdentity { get; set; }
    
        public virtual AcademicSubjectDescriptor AcademicSubjectDescriptor { get; set; }
        public virtual CreditType CreditType { get; set; }
        public virtual GraduationPlan GraduationPlan { get; set; }
    }
}
