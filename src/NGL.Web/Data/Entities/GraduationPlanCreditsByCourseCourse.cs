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
    
    public partial class GraduationPlanCreditsByCourseCourse
    {
        public GraduationPlanCreditsByCourseCourse()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int EducationOrganizationId { get; set; }
        public int GraduationPlanTypeDescriptorId { get; set; }
        public short GraduationSchoolYear { get; set; }
        public string CourseSetName { get; set; }
        public int CourseEducationOrganizationId { get; set; }
        public string CourseCode { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual GraduationPlanCreditsByCourse GraduationPlanCreditsByCourse { get; set; }
    }
}
