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
    
    public partial class SchoolCategory
    {
        public SchoolCategory()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int SchoolId { get; set; }
        public int SchoolCategoryTypeId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int SchoolCategoryIdentity { get; set; }
    
        public virtual School School { get; set; }
        public virtual SchoolCategoryType SchoolCategoryType { get; set; }
    }
}
