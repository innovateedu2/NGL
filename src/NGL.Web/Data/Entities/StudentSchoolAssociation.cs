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
    
    public partial class StudentSchoolAssociation
    {
        public StudentSchoolAssociation()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
            this.StudentSchoolAssociationEducationPlans = new HashSet<StudentSchoolAssociationEducationPlan>();
        }
    
        public int StudentUSI { get; set; }
        public int SchoolId { get; set; }
        public Nullable<short> SchoolYear { get; set; }
        public System.DateTime EntryDate { get; set; }
        public int EntryGradeLevelDescriptorId { get; set; }
        public Nullable<int> EntryGradeLevelReasonTypeId { get; set; }
        public Nullable<int> EntryTypeDescriptorId { get; set; }
        public Nullable<bool> RepeatGradeIndicator { get; set; }
        public Nullable<bool> SchoolChoiceTransfer { get; set; }
        public Nullable<System.DateTime> ExitWithdrawDate { get; set; }
        public Nullable<int> ExitWithdrawTypeDescriptorId { get; set; }
        public Nullable<int> ResidencyStatusDescriptorId { get; set; }
        public Nullable<bool> PrimarySchool { get; set; }
        public Nullable<bool> EmployedWhileEnrolled { get; set; }
        public Nullable<short> ClassOfSchoolYear { get; set; }
        public Nullable<int> EducationOrganizationId { get; set; }
        public Nullable<int> GraduationPlanTypeDescriptorId { get; set; }
        public Nullable<short> GraduationSchoolYear { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StudentSchoolAssociationIdentity { get; set; }
    
        public virtual EntryGradeLevelReasonType EntryGradeLevelReasonType { get; set; }
        public virtual EntryTypeDescriptor EntryTypeDescriptor { get; set; }
        public virtual ExitWithdrawTypeDescriptor ExitWithdrawTypeDescriptor { get; set; }
        public virtual GradeLevelDescriptor GradeLevelDescriptor { get; set; }
        public virtual GraduationPlan GraduationPlan { get; set; }
        public virtual ResidencyStatusDescriptor ResidencyStatusDescriptor { get; set; }
        public virtual School School { get; set; }
        public virtual SchoolYearType SchoolYearType { get; set; }
        public virtual SchoolYearType SchoolYearType1 { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<StudentSchoolAssociationEducationPlan> StudentSchoolAssociationEducationPlans { get; set; }
    }
}
