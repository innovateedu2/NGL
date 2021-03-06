﻿using Humanizer;
using NGL.Web.Data.Repositories;

namespace NGL.Web.Models.Session
{
    public class CreateModelToSessionMapper : MapperBase<CreateModel, Data.Entities.Session>
    {
        private readonly ISchoolRepository _schoolRepository;

        public CreateModelToSessionMapper(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        public override void Map(CreateModel source, Data.Entities.Session target)
        {
            target.SchoolId = _schoolRepository.GetSchool().SchoolId;
            target.TermTypeId = (int) source.Term.GetValueOrDefault();
            target.SchoolYear = (short) source.SchoolYear;
            target.BeginDate = source.BeginDate.GetValueOrDefault();
            target.EndDate = source.EndDate.GetValueOrDefault();
            target.SessionName = source.Term.Humanize() + " " + (GetFullSchoolYear(source));
            target.TotalInstructionalDays = source.TotalInstructionalDays.GetValueOrDefault();
            
        }

        private static string GetFullSchoolYear(CreateModel source)
        {
            return (int) (source.SchoolYear-1) + "-" + (int) source.SchoolYear;
        }
    }
}