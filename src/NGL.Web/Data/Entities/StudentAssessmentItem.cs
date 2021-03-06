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
    
    public partial class StudentAssessmentItem
    {
        public StudentAssessmentItem()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StudentUSI { get; set; }
        public string AssessmentTitle { get; set; }
        public int AcademicSubjectDescriptorId { get; set; }
        public int AssessedGradeLevelDescriptorId { get; set; }
        public int Version { get; set; }
        public string IdentificationCode { get; set; }
        public System.DateTime AdministrationDate { get; set; }
        public string AssessmentResponse { get; set; }
        public Nullable<int> ResponseIndicatorTypeId { get; set; }
        public int AssessmentItemResultTypeId { get; set; }
        public Nullable<int> RawScoreResult { get; set; }
        public string TimeAssessed { get; set; }
        public string DescriptiveFeedback { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StudentAssessmentItemIdentity { get; set; }
    
        public virtual AssessmentItem AssessmentItem { get; set; }
        public virtual AssessmentItemResultType AssessmentItemResultType { get; set; }
        public virtual ResponseIndicatorType ResponseIndicatorType { get; set; }
        public virtual StudentAssessment StudentAssessment { get; set; }
    }
}
