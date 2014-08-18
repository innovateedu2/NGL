﻿using System.Collections.Generic;
using System.Linq;

namespace NGL.Web.Models.Attendance
{
    public class TakeAttendanceModelToStudentSectionAttendanceEventListMapper
    {
        public IEnumerable<Data.Entities.StudentSectionAttendanceEvent> Build(TakeAttendanceModel takeAttendanceModel, Data.Entities.Section section)
        {
            return takeAttendanceModel.StudentRows.Select(sr => new Data.Entities.StudentSectionAttendanceEvent
            {
                StudentUSI = sr.StudentUsi, 
                AttendanceEventCategoryDescriptorId = (int) sr.AttendanceType, 
                EventDate = takeAttendanceModel.Date,
                SchoolId = section.SchoolId, 
                ClassPeriodName = section.ClassPeriodName, 
                ClassroomIdentificationCode = section.ClassroomIdentificationCode, 
                LocalCourseCode = section.LocalCourseCode, 
                TermTypeId = section.TermTypeId, 
                SchoolYear = section.SchoolYear
            });
        }
    }
}