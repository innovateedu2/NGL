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
    
    public partial class RestraintEvent
    {
        public RestraintEvent()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
            this.RestraintEventPrograms = new HashSet<RestraintEventProgram>();
            this.RestraintEventReasons = new HashSet<RestraintEventReason>();
        }
    
        public int StudentUSI { get; set; }
        public int SchoolId { get; set; }
        public string RestraintEventIdentifier { get; set; }
        public System.DateTime EventDate { get; set; }
        public Nullable<int> EducationalEnvironmentTypeId { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int RestraintEventIdentity { get; set; }
    
        public virtual EducationalEnvironmentType EducationalEnvironmentType { get; set; }
        public virtual School School { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<RestraintEventProgram> RestraintEventPrograms { get; set; }
        public virtual ICollection<RestraintEventReason> RestraintEventReasons { get; set; }
    }
}
