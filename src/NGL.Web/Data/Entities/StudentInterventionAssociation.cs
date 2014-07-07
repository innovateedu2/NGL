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
    
    public partial class StudentInterventionAssociation
    {
        public StudentInterventionAssociation()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
            this.StudentInterventionAssociationInterventionEffectivenesses = new HashSet<StudentInterventionAssociationInterventionEffectiveness>();
        }
    
        public int StudentUSI { get; set; }
        public string InterventionIdentificationCode { get; set; }
        public int InterventionEducationOrganizationId { get; set; }
        public Nullable<int> EducationOrganizationId { get; set; }
        public string CohortIdentifier { get; set; }
        public string DiagnosticStatement { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StudentInterventionAssociationIdentity { get; set; }
    
        public virtual Cohort Cohort { get; set; }
        public virtual Intervention Intervention { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<StudentInterventionAssociationInterventionEffectiveness> StudentInterventionAssociationInterventionEffectivenesses { get; set; }
    }
}
