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
    
    public partial class AssessmentFamilyAssessmentPeriod
    {
        public AssessmentFamilyAssessmentPeriod()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public string AssessmentFamilyTitle { get; set; }
        public int AssessmentPeriodDescriptorId { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual AssessmentFamily AssessmentFamily { get; set; }
        public virtual AssessmentPeriodDescriptor AssessmentPeriodDescriptor { get; set; }
    }
}
