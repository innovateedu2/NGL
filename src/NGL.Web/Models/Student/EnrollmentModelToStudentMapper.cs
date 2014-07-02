﻿using System.Collections.ObjectModel;
using NGL.Web.Data.Entities;
using Ninject.Planning.Targets;

namespace NGL.Web.Models.Student
{
    public class EnrollmentModelToStudentMapper : IMapper<EnrollmentModel, Data.Entities.Student>
    {
        public void Map(EnrollmentModel source, Data.Entities.Student target)
        {
            target.FirstName = source.FirstName;
            target.LastSurname = source.LastSurname;
            target.HispanicLatinoEthnicity = source.HispanicLatinoEthnicity;
            target.SexTypeId = source.SexTypeId;
            target.BirthDate = source.BirthDate;
            target.OldEthnicityTypeId = source.OldEthnicityTypeId;

            target.StudentAddresses.Add(new StudentAddress
            {
                StreetNumberName = source.StreetNumberName,
                ApartmentRoomSuiteNumber = source.ApartmentRoomSuiteNumber,
                City = source.City,
                PostalCode = source.PostalCode,
                StateAbbreviationTypeId = source.StateAbbreviationTypeId
            });

            var studentLanguage = new StudentLanguage
            {
                LanguageDescriptorId = source.LanguageDescriptorId
            };

            target.StudentLanguages.Add(studentLanguage);
            studentLanguage.StudentLanguageUses.Add( new StudentLanguageUse
            {
                LanguageUseTypeId = source.LanguageUseTypeId
            });
        }   
    }
}