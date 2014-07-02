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
    
    public partial class StudentAcademicRecordDiploma
    {
        public StudentAcademicRecordDiploma()
        {
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int StudentUSI { get; set; }
        public int DiplomaTypeId { get; set; }
        public short SchoolYear { get; set; }
        public int EducationOrganizationId { get; set; }
        public System.DateTime DiplomaAwardDate { get; set; }
        public Nullable<int> DiplomaLevelTypeId { get; set; }
        public int TermTypeId { get; set; }
        public Nullable<bool> CTECompleter { get; set; }
        public string DiplomaDescription { get; set; }
        public Nullable<System.DateTime> DiplomaAwardExpiresDate { get; set; }
        public string AchievementTitle { get; set; }
        public int AchievementCategoryDescriptorId { get; set; }
        public string AchievementCategorySystem { get; set; }
        public string IssuerName { get; set; }
        public string IssuerOriginURL { get; set; }
        public string Criteria { get; set; }
        public string CriteriaURL { get; set; }
        public string EvidenceStatement { get; set; }
        public string ImageURL { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual AchievementCategoryDescriptor AchievementCategoryDescriptor { get; set; }
        public virtual DiplomaLevelType DiplomaLevelType { get; set; }
        public virtual DiplomaType DiplomaType { get; set; }
        public virtual StudentAcademicRecord StudentAcademicRecord { get; set; }
    }
}
