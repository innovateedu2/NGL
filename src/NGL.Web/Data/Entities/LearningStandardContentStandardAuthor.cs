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
    
    public partial class LearningStandardContentStandardAuthor
    {
        public LearningStandardContentStandardAuthor()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public string LearningStandardId { get; set; }
        public string Author { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int LearningStandardContentStandardAuthorIdentity { get; set; }
    
        public virtual LearningStandardContentStandard LearningStandardContentStandard { get; set; }
    }
}
