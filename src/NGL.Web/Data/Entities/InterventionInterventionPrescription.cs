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
    
    public partial class InterventionInterventionPrescription
    {
        public InterventionInterventionPrescription()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public string InterventionIdentificationCode { get; set; }
        public int EducationOrganizationId { get; set; }
        public string InterventionPrescriptionIdentificationCode { get; set; }
        public int InterventionPrescriptionEducationOrganizationId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int InterventionInterventionPrescriptionIdentity { get; set; }
    
        public virtual Intervention Intervention { get; set; }
        public virtual InterventionPrescription InterventionPrescription { get; set; }
    }
}
