﻿namespace NGL.Web.Models.Course
{
    public class CourseToCourseModelMapper : MapperBase<Data.Entities.Course, CourseModel>
    {

        public override void Map(Data.Entities.Course source, CourseModel target)
        {
            target.CourseCode = source.CourseCode;
            target.CourseTitle = source.CourseTitle;
            target.NumberOfParts = source.NumberOfParts;
            target.AcademicSubjectDescriptorId = source.AcademicSubjectDescriptorId;
            target.CourseDescription = source.CourseDescription;
            target.DateCourseAdopted = source.DateCourseAdopted;
            target.HighSchoolCourseRequirement = source.HighSchoolCourseRequirement;
            target.CourseGPAApplicabilityTypeId = source.CourseGPAApplicabilityTypeId;
            target.CourseDefinedByTypeId = source.CourseDefinedByTypeId;
            target.MinimumAvailableCreditTypeId = source.MinimumAvailableCreditTypeId;
            target.MinimumAvailableCreditConversion = source.MinimumAvailableCreditConversion;
            target.MinimumAvailableCredit = source.MinimumAvailableCredit;
            target.MaximumAvailableCreditTypeId = source.MaximumAvailableCreditTypeId;
            target.MaximumAvailableCreditConversion = source.MaximumAvailableCreditConversion;
            target.MaximumAvailableCredit = source.MaximumAvailableCredit;
            target.CareerPathwayTypeId = source.CareerPathwayTypeId;
            target.TimeRequiredForCompletion = source.TimeRequiredForCompletion;
        }
    }
}