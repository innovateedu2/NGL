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
    
    public partial class StaffEducationOrganizationEmploymentAssociation
    {
        public StaffEducationOrganizationEmploymentAssociation()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
            this.StaffEducationOrganizationAssignmentAssociations = new HashSet<StaffEducationOrganizationAssignmentAssociation>();
        }
    
        public int StaffUSI { get; set; }
        public int EducationOrganizationId { get; set; }
        public int EmploymentStatusDescriptorId { get; set; }
        public System.DateTime HireDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> SeparationTypeId { get; set; }
        public Nullable<int> SeparationReasonDescriptorId { get; set; }
        public string Department { get; set; }
        public Nullable<decimal> FullTimeEquivalency { get; set; }
        public Nullable<System.DateTime> OfferDate { get; set; }
        public Nullable<decimal> HourlyWage { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StaffEducationOrganizationEmploymentAssociationIdentity { get; set; }
    
        public virtual EducationOrganization EducationOrganization { get; set; }
        public virtual EmploymentStatusDescriptor EmploymentStatusDescriptor { get; set; }
        public virtual SeparationReasonDescriptor SeparationReasonDescriptor { get; set; }
        public virtual SeparationType SeparationType { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<StaffEducationOrganizationAssignmentAssociation> StaffEducationOrganizationAssignmentAssociations { get; set; }
    }
}
