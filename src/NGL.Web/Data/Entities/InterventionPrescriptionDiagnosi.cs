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
    
    public partial class InterventionPrescriptionDiagnosi
    {
        public InterventionPrescriptionDiagnosi()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public string InterventionPrescriptionIdentificationCode { get; set; }
        public int EducationOrganizationId { get; set; }
        public int DiagnosisDescriptorId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int InterventionPrescriptionDiagnosisIdentity { get; set; }
    
        public virtual DiagnosisDescriptor DiagnosisDescriptor { get; set; }
        public virtual InterventionPrescription InterventionPrescription { get; set; }
    }
}
