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
    
    public partial class ClassroomPositionDescriptor
    {
        public ClassroomPositionDescriptor()
        {
            this.StaffSectionAssociations = new HashSet<StaffSectionAssociation>();
        }
    
        public int ClassroomPositionDescriptorId { get; set; }
        public Nullable<int> ClassroomPositionTypeId { get; set; }
    
        public virtual ClassroomPositionType ClassroomPositionType { get; set; }
        public virtual Descriptor Descriptor { get; set; }
        public virtual ICollection<StaffSectionAssociation> StaffSectionAssociations { get; set; }
    }
}
