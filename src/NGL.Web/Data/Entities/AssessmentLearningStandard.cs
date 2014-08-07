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
    
    public partial class AssessmentLearningStandard
    {
        public AssessmentLearningStandard()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
        }
    
        public System.Guid Id { get; set; }
        public string AssessmentTitle { get; set; }
        public int AcademicSubjectDescriptorId { get; set; }
        public int AssessedGradeLevelDescriptorId { get; set; }
        public int Version { get; set; }
        public string LearningStandardId { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int LearningStandardIdentity { get; set; }
    
        public virtual Assessment Assessment { get; set; }
        public virtual LearningStandard LearningStandard { get; set; }
    }
}