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
    
    public partial class StudentElectronicMail
    {
        public StudentElectronicMail()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StudentUSI { get; set; }
        public int ElectronicMailTypeId { get; set; }
        public string ElectronicMailAddress { get; set; }
        public Nullable<bool> PrimaryEmailAddressIndicator { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StudentElectronicMailIdentity { get; set; }
    
        public virtual ElectronicMailType ElectronicMailType { get; set; }
        public virtual Student Student { get; set; }
    }
}
