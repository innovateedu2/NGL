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
    
    public partial class OpenStaffPositionAcademicSubject
    {
        public OpenStaffPositionAcademicSubject()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int EducationOrganizationId { get; set; }
        public int StaffClassificationDescriptorId { get; set; }
        public string RequisitionNumber { get; set; }
        public System.DateTime DatePosted { get; set; }
        public int AcademicSubjectDescriptorId { get; set; }
        public int EmploymentStatusDescriptorId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int OpenStaffPositionAcademicSubjectIdentity { get; set; }
    
        public virtual AcademicSubjectDescriptor AcademicSubjectDescriptor { get; set; }
        public virtual OpenStaffPosition OpenStaffPosition { get; set; }
    }
}
