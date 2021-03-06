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
    
    public partial class PerformanceLevelDescriptor
    {
        public PerformanceLevelDescriptor()
        {
            this.AssessmentPerformanceLevels = new HashSet<AssessmentPerformanceLevel>();
            this.ObjectiveAssessmentPerformanceLevels = new HashSet<ObjectiveAssessmentPerformanceLevel>();
            this.StudentAssessmentPerformanceLevels = new HashSet<StudentAssessmentPerformanceLevel>();
            this.StudentAssessmentStudentObjectiveAssessmentPerformanceLevels = new HashSet<StudentAssessmentStudentObjectiveAssessmentPerformanceLevel>();
        }
    
        public int PerformanceLevelDescriptorId { get; set; }
        public Nullable<int> PerformanceBaseConversionTypeId { get; set; }
    
        public virtual ICollection<AssessmentPerformanceLevel> AssessmentPerformanceLevels { get; set; }
        public virtual Descriptor Descriptor { get; set; }
        public virtual ICollection<ObjectiveAssessmentPerformanceLevel> ObjectiveAssessmentPerformanceLevels { get; set; }
        public virtual PerformanceBaseConversionType PerformanceBaseConversionType { get; set; }
        public virtual ICollection<StudentAssessmentPerformanceLevel> StudentAssessmentPerformanceLevels { get; set; }
        public virtual ICollection<StudentAssessmentStudentObjectiveAssessmentPerformanceLevel> StudentAssessmentStudentObjectiveAssessmentPerformanceLevels { get; set; }
    }
}
