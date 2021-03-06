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
    
    public partial class StudentAssessment
    {
        public StudentAssessment()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
            this.StudentAssessmentAccommodations = new HashSet<StudentAssessmentAccommodation>();
            this.StudentAssessmentItems = new HashSet<StudentAssessmentItem>();
            this.StudentAssessmentPerformanceLevels = new HashSet<StudentAssessmentPerformanceLevel>();
            this.StudentAssessmentScoreResults = new HashSet<StudentAssessmentScoreResult>();
            this.StudentAssessmentStudentObjectiveAssessments = new HashSet<StudentAssessmentStudentObjectiveAssessment>();
        }
    
        public int StudentUSI { get; set; }
        public string AssessmentTitle { get; set; }
        public int AcademicSubjectDescriptorId { get; set; }
        public int AssessedGradeLevelDescriptorId { get; set; }
        public int Version { get; set; }
        public System.DateTime AdministrationDate { get; set; }
        public Nullable<System.DateTime> AdministrationEndDate { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<int> AdministrationLanguageDescriptorId { get; set; }
        public Nullable<int> AdministrationEnvironmentTypeId { get; set; }
        public Nullable<int> RetestIndicatorTypeId { get; set; }
        public Nullable<int> ReasonNotTestedTypeId { get; set; }
        public Nullable<int> WhenAssessedGradeLevelDescriptorId { get; set; }
        public Nullable<int> EventCircumstanceTypeId { get; set; }
        public string EventDescription { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StudentAssessmentIdentity { get; set; }
    
        public virtual AdministrationEnvironmentType AdministrationEnvironmentType { get; set; }
        public virtual Assessment Assessment { get; set; }
        public virtual EventCircumstanceType EventCircumstanceType { get; set; }
        public virtual GradeLevelDescriptor GradeLevelDescriptor { get; set; }
        public virtual LanguageDescriptor LanguageDescriptor { get; set; }
        public virtual ReasonNotTestedType ReasonNotTestedType { get; set; }
        public virtual RetestIndicatorType RetestIndicatorType { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<StudentAssessmentAccommodation> StudentAssessmentAccommodations { get; set; }
        public virtual ICollection<StudentAssessmentItem> StudentAssessmentItems { get; set; }
        public virtual ICollection<StudentAssessmentPerformanceLevel> StudentAssessmentPerformanceLevels { get; set; }
        public virtual ICollection<StudentAssessmentScoreResult> StudentAssessmentScoreResults { get; set; }
        public virtual ICollection<StudentAssessmentStudentObjectiveAssessment> StudentAssessmentStudentObjectiveAssessments { get; set; }
    }
}
