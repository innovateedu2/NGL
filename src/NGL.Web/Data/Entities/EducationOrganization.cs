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
    
    public partial class EducationOrganization
    {
        public EducationOrganization()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
            this.Accounts = new HashSet<Account>();
            this.AccountabilityRatings = new HashSet<AccountabilityRating>();
            this.AssessmentContentStandards = new HashSet<AssessmentContentStandard>();
            this.AssessmentFamilyContentStandards = new HashSet<AssessmentFamilyContentStandard>();
            this.CalendarDates = new HashSet<CalendarDate>();
            this.Cohorts = new HashSet<Cohort>();
            this.CompetencyObjectives = new HashSet<CompetencyObjective>();
            this.Courses = new HashSet<Course>();
            this.EducationOrganizationAddresses = new HashSet<EducationOrganizationAddress>();
            this.EducationOrganizationCategories = new HashSet<EducationOrganizationCategory>();
            this.EducationOrganizationIdentificationCodes = new HashSet<EducationOrganizationIdentificationCode>();
            this.EducationOrganizationInstitutionTelephones = new HashSet<EducationOrganizationInstitutionTelephone>();
            this.EducationOrganizationInternationalAddresses = new HashSet<EducationOrganizationInternationalAddress>();
            this.EducationOrganizationInterventionPrescriptionAssociations = new HashSet<EducationOrganizationInterventionPrescriptionAssociation>();
            this.EducationOrganizationNetworkAssociations = new HashSet<EducationOrganizationNetworkAssociation>();
            this.EducationOrganizationPeerAssociations = new HashSet<EducationOrganizationPeerAssociation>();
            this.EducationOrganizationPeerAssociations1 = new HashSet<EducationOrganizationPeerAssociation>();
            this.GraduationPlans = new HashSet<GraduationPlan>();
            this.Interventions = new HashSet<Intervention>();
            this.InterventionPrescriptions = new HashSet<InterventionPrescription>();
            this.InterventionStudies = new HashSet<InterventionStudy>();
            this.LearningObjectiveContentStandards = new HashSet<LearningObjectiveContentStandard>();
            this.LearningStandardContentStandards = new HashSet<LearningStandardContentStandard>();
            this.OpenStaffPositions = new HashSet<OpenStaffPosition>();
            this.Programs = new HashSet<Program>();
            this.StaffEducationOrganizationEmploymentAssociations = new HashSet<StaffEducationOrganizationEmploymentAssociation>();
            this.StaffEducationOrganizationAssignmentAssociations = new HashSet<StaffEducationOrganizationAssignmentAssociation>();
            this.StudentAcademicRecords = new HashSet<StudentAcademicRecord>();
            this.StudentEducationOrganizationAssociations = new HashSet<StudentEducationOrganizationAssociation>();
            this.StudentProgramAssociations = new HashSet<StudentProgramAssociation>();
        }
    
        public int EducationOrganizationId { get; set; }
        public string StateOrganizationId { get; set; }
        public string NameOfInstitution { get; set; }
        public string ShortNameOfInstitution { get; set; }
        public string WebSite { get; set; }
        public Nullable<int> OperationalStatusTypeId { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int EducationOrganizationIdentity { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<AccountabilityRating> AccountabilityRatings { get; set; }
        public virtual ICollection<AssessmentContentStandard> AssessmentContentStandards { get; set; }
        public virtual ICollection<AssessmentFamilyContentStandard> AssessmentFamilyContentStandards { get; set; }
        public virtual ICollection<CalendarDate> CalendarDates { get; set; }
        public virtual ICollection<Cohort> Cohorts { get; set; }
        public virtual ICollection<CompetencyObjective> CompetencyObjectives { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual OperationalStatusType OperationalStatusType { get; set; }
        public virtual ICollection<EducationOrganizationAddress> EducationOrganizationAddresses { get; set; }
        public virtual ICollection<EducationOrganizationCategory> EducationOrganizationCategories { get; set; }
        public virtual ICollection<EducationOrganizationIdentificationCode> EducationOrganizationIdentificationCodes { get; set; }
        public virtual ICollection<EducationOrganizationInstitutionTelephone> EducationOrganizationInstitutionTelephones { get; set; }
        public virtual ICollection<EducationOrganizationInternationalAddress> EducationOrganizationInternationalAddresses { get; set; }
        public virtual ICollection<EducationOrganizationInterventionPrescriptionAssociation> EducationOrganizationInterventionPrescriptionAssociations { get; set; }
        public virtual EducationOrganizationNetwork EducationOrganizationNetwork { get; set; }
        public virtual ICollection<EducationOrganizationNetworkAssociation> EducationOrganizationNetworkAssociations { get; set; }
        public virtual ICollection<EducationOrganizationPeerAssociation> EducationOrganizationPeerAssociations { get; set; }
        public virtual ICollection<EducationOrganizationPeerAssociation> EducationOrganizationPeerAssociations1 { get; set; }
        public virtual EducationServiceCenter EducationServiceCenter { get; set; }
        public virtual ICollection<GraduationPlan> GraduationPlans { get; set; }
        public virtual ICollection<Intervention> Interventions { get; set; }
        public virtual ICollection<InterventionPrescription> InterventionPrescriptions { get; set; }
        public virtual ICollection<InterventionStudy> InterventionStudies { get; set; }
        public virtual ICollection<LearningObjectiveContentStandard> LearningObjectiveContentStandards { get; set; }
        public virtual ICollection<LearningStandardContentStandard> LearningStandardContentStandards { get; set; }
        public virtual LocalEducationAgency LocalEducationAgency { get; set; }
        public virtual ICollection<OpenStaffPosition> OpenStaffPositions { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
        public virtual School School { get; set; }
        public virtual ICollection<StaffEducationOrganizationEmploymentAssociation> StaffEducationOrganizationEmploymentAssociations { get; set; }
        public virtual ICollection<StaffEducationOrganizationAssignmentAssociation> StaffEducationOrganizationAssignmentAssociations { get; set; }
        public virtual StateEducationAgency StateEducationAgency { get; set; }
        public virtual ICollection<StudentAcademicRecord> StudentAcademicRecords { get; set; }
        public virtual ICollection<StudentEducationOrganizationAssociation> StudentEducationOrganizationAssociations { get; set; }
        public virtual ICollection<StudentProgramAssociation> StudentProgramAssociations { get; set; }
    }
}
