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
    
    public partial class StudentProgramStatus
    {
        public StudentProgramStatus()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StudentUSI { get; set; }
        public bool TestingAccommodation { get; set; }
        public bool BilingualProgram { get; set; }
        public bool EnglishAsSecondLanguage { get; set; }
        public int SchoolFoodServicesEligibilityTypeId { get; set; }
        public bool Gifted { get; set; }
        public bool SpecialEducation { get; set; }
        public bool TitleParticipation { get; set; }
        public bool McKinneyVento { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string TestingAccommodationFile { get; set; }
        public string SpecialEducationFile { get; set; }
        public string TitleParticipationFile { get; set; }
        public string McKinneyVentoFile { get; set; }
    
        public virtual SchoolFoodServicesEligibilityType SchoolFoodServicesEligibilityType { get; set; }
        public virtual Student Student { get; set; }
    }
}
