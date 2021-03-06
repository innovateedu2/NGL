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
    
    public partial class CourseTranscriptAdditionalCredit
    {
        public CourseTranscriptAdditionalCredit()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StudentUSI { get; set; }
        public short SchoolYear { get; set; }
        public int TermTypeId { get; set; }
        public int CourseEducationOrganizationId { get; set; }
        public string CourseCode { get; set; }
        public int CourseAttemptResultTypeId { get; set; }
        public int AdditionalCreditTypeId { get; set; }
        public decimal Credit { get; set; }
        public int EducationOrganizationId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CourseTranscriptAdditionalCreditIdentity { get; set; }
    
        public virtual AdditionalCreditType AdditionalCreditType { get; set; }
        public virtual CourseTranscript CourseTranscript { get; set; }
    }
}
