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
    
    public partial class EducationOrganizationIdentificationCode
    {
        public EducationOrganizationIdentificationCode()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int EducationOrganizationId { get; set; }
        public int EducationOrganizationIdentificationSystemTypeId { get; set; }
        public string IdentificationCode { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int EducationOrganizationIdentificationCodeIdentity { get; set; }
    
        public virtual EducationOrganization EducationOrganization { get; set; }
        public virtual EducationOrganizationIdentificationSystemType EducationOrganizationIdentificationSystemType { get; set; }
    }
}
