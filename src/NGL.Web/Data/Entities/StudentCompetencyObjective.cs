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
    
    public partial class StudentCompetencyObjective
    {
        public StudentCompetencyObjective()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StudentUSI { get; set; }
        public int GradingPeriodEducationOrganizationId { get; set; }
        public int GradingPeriodDescriptorId { get; set; }
        public System.DateTime GradingPeriodBeginDate { get; set; }
        public string Objective { get; set; }
        public int ObjectiveGradeLevelDescriptorId { get; set; }
        public int EducationOrganizationId { get; set; }
        public int CompetencyLevelDescriptorId { get; set; }
        public string DiagnosticStatement { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string LocalCourseCode { get; set; }
        public Nullable<int> TermTypeId { get; set; }
        public Nullable<short> SchoolYear { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public Nullable<int> ProgramEducationOrganizationId { get; set; }
        public Nullable<int> ProgramTypeId { get; set; }
        public string ProgramName { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StudentCompetencyObjectiveIdentity { get; set; }
    
        public virtual CompetencyLevelDescriptor CompetencyLevelDescriptor { get; set; }
        public virtual CompetencyObjective CompetencyObjective { get; set; }
        public virtual GradingPeriod GradingPeriod { get; set; }
        public virtual ReportCardStudentCompetencyObjective ReportCardStudentCompetencyObjective { get; set; }
        public virtual StudentProgramAssociation StudentProgramAssociation { get; set; }
        public virtual StudentSectionAssociation StudentSectionAssociation { get; set; }
    }
}
