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
    
    public partial class SectionCharacteristic
    {
        public SectionCharacteristic()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int SchoolId { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string LocalCourseCode { get; set; }
        public int TermTypeId { get; set; }
        public short SchoolYear { get; set; }
        public int SectionCharacteristicDescriptorId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int SectionCharacteristicIdentity { get; set; }
    
        public virtual Section Section { get; set; }
        public virtual SectionCharacteristicDescriptor SectionCharacteristicDescriptor { get; set; }
    }
}
