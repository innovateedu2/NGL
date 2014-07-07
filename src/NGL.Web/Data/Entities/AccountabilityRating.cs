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
    
    public partial class AccountabilityRating
    {
        public AccountabilityRating()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int EducationOrganizationId { get; set; }
        public string RatingTitle { get; set; }
        public short SchoolYear { get; set; }
        public string Rating { get; set; }
        public Nullable<System.DateTime> RatingDate { get; set; }
        public string RatingOrganization { get; set; }
        public string RatingProgram { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int AccountabilityRatingIdentity { get; set; }
    
        public virtual EducationOrganization EducationOrganization { get; set; }
        public virtual SchoolYearType SchoolYearType { get; set; }
    }
}
