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
    
    public partial class ObjectiveAssessmentLearningStandard
    {
        public ObjectiveAssessmentLearningStandard()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public string AssessmentTitle { get; set; }
        public int AcademicSubjectDescriptorId { get; set; }
        public int AssessedGradeLevelDescriptorId { get; set; }
        public int Version { get; set; }
        public string IdentificationCode { get; set; }
        public string LearningStandardId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int ObjectiveAssessmentLearningStandardIdentity { get; set; }
    
        public virtual LearningStandard LearningStandard { get; set; }
        public virtual ObjectiveAssessment ObjectiveAssessment { get; set; }
    }
}
