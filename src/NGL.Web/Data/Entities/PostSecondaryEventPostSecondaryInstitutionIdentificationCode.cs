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
    
    public partial class PostSecondaryEventPostSecondaryInstitutionIdentificationCode
    {
        public PostSecondaryEventPostSecondaryInstitutionIdentificationCode()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StudentUSI { get; set; }
        public int PostSecondaryEventCategoryTypeId { get; set; }
        public System.DateTime EventDate { get; set; }
        public int EducationOrganizationIdentificationSystemTypeId { get; set; }
        public string IdentificationCode { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int PostSecondaryEventPostSecondaryInstitutionIdentificationCodeIdentity { get; set; }
    
        public virtual EducationOrganizationIdentificationSystemType EducationOrganizationIdentificationSystemType { get; set; }
        public virtual PostSecondaryEventPostSecondaryInstitution PostSecondaryEventPostSecondaryInstitution { get; set; }
    }
}
