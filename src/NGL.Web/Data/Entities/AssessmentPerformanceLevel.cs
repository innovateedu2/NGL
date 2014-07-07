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
    
    public partial class AssessmentPerformanceLevel
    {
        public AssessmentPerformanceLevel()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public string AssessmentTitle { get; set; }
        public int AcademicSubjectDescriptorId { get; set; }
        public int AssessedGradeLevelDescriptorId { get; set; }
        public int Version { get; set; }
        public int PerformanceLevelDescriptorId { get; set; }
        public int AssessmentReportingMethodTypeId { get; set; }
        public string MinimumScore { get; set; }
        public string MaximumScore { get; set; }
        public Nullable<int> ResultDatatypeTypeId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int AssessmentPerformanceLevelIdentity { get; set; }
    
        public virtual Assessment Assessment { get; set; }
        public virtual AssessmentReportingMethodType AssessmentReportingMethodType { get; set; }
        public virtual PerformanceLevelDescriptor PerformanceLevelDescriptor { get; set; }
        public virtual ResultDatatypeType ResultDatatypeType { get; set; }
    }
}
