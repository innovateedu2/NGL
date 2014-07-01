namespace NGL.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public class SectionAttendanceTakenEvent
    {
        public SectionAttendanceTakenEvent()
        {
    		this.Id = System.Guid.NewGuid();
    		this.LastModifiedDate = System.DateTime.Now;
    		this.CreateDate = System.DateTime.Now;
        }
    
        public int SchoolId { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string LocalCourseCode { get; set; }
        public int TermTypeId { get; set; }
        public short SchoolYear { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime EventDate { get; set; }
        public Nullable<int> StaffUSI { get; set; }
        public System.Guid Id { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual Section Section { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
