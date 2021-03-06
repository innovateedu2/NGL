﻿using System.Collections.Generic;
using System.Linq;
using NGL.Web.Data.Entities;
using NGL.Web.Data.Infrastructure;

namespace NGL.Web.Data.Repositories
{
    public class AssessmentSectionRepository : RepositoryBase, IAssessmentSectionRepository
    {
        public AssessmentSectionRepository(INglDbContext dbContext) : base(dbContext) { }
        public IEnumerable<AssessmentSection> GetByStudentSectionAssociation(StudentSectionAssociation studentSectionAssociation)
        {
            return DbContext.Set<AssessmentSection>()
                .Where(
                    assessmentSection =>
                        assessmentSection.ClassPeriodName == studentSectionAssociation.ClassPeriodName
                        && assessmentSection.SchoolId == studentSectionAssociation.SchoolId
                        && assessmentSection.ClassroomIdentificationCode == studentSectionAssociation.ClassroomIdentificationCode
                        && assessmentSection.LocalCourseCode == studentSectionAssociation.LocalCourseCode
                        && assessmentSection.TermTypeId == studentSectionAssociation.TermTypeId
                        && assessmentSection.SchoolYear == studentSectionAssociation.SchoolYear
                        && assessmentSection.Assessment.StudentAssessments.Any(
                            sa => sa.StudentUSI == studentSectionAssociation.StudentUSI
                            && sa.AdministrationDate >= studentSectionAssociation.BeginDate 
                            && sa.AdministrationDate <= studentSectionAssociation.EndDate)
                            ).ToList();
        }
    }
}