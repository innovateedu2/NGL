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
    
    public partial class StudentAcademicRecordClassRanking
    {
        public StudentAcademicRecordClassRanking()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StudentUSI { get; set; }
        public int EducationOrganizationId { get; set; }
        public short SchoolYear { get; set; }
        public int TermTypeId { get; set; }
        public int ClassRank { get; set; }
        public int TotalNumberInClass { get; set; }
        public Nullable<int> PercentageRanking { get; set; }
        public Nullable<System.DateTime> ClassRankingDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int StudentAcademicRecordClassRankingIdentity { get; set; }
    
        public virtual StudentAcademicRecord StudentAcademicRecord { get; set; }
    }
}
