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
    
    public partial class TeachingCredentialDescriptor
    {
        public TeachingCredentialDescriptor()
        {
            this.StaffCredentials = new HashSet<StaffCredential>();
        }
    
        public int TeachingCredentialDescriptorId { get; set; }
        public Nullable<int> TeachingCredentialTypeId { get; set; }
    
        public virtual Descriptor Descriptor { get; set; }
        public virtual ICollection<StaffCredential> StaffCredentials { get; set; }
        public virtual TeachingCredentialType TeachingCredentialType { get; set; }
    }
}
