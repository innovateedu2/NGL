﻿using System;
using NGL.Web.Data.Entities;
using NGL.Web.Data.Infrastructure;
using NGL.Web.Data.Repositories;

namespace NGL.Web.Models.Student
{
    public class EnrollmentModelToStudentMapper : IMapper<EnrollmentModel, Data.Entities.Student>
    {
        private const int HomeAddressTypeId = 1;
        private const int HomeLanguageTypeId = 1;

        public void Map(EnrollmentModel source, Data.Entities.Student target)
        {
            SetStudentNativeProperties(source, target);

            SetStudentAddress(source, target);

            SetStudentLanguage(source, target);
        }

        private static void SetStudentNativeProperties(EnrollmentModel source, Data.Entities.Student target)
        {
            if (source.StudentUsi != null) target.StudentUSI = (int)source.StudentUsi;
            target.FirstName = source.FirstName;
            target.LastSurname = source.LastSurname;
            target.HispanicLatinoEthnicity = source.HispanicLatinoEthnicity;
            target.SexTypeId = (int?) source.SexTypeEnum.GetValueOrDefault();
            if (source.BirthDate != null) target.BirthDate = (DateTime) source.BirthDate;
            target.OldEthnicityTypeId = (int?) source.OldEthnicityTypeEnum.GetValueOrDefault();
        }

        private void SetStudentLanguage(EnrollmentModel source, Data.Entities.Student target)
        {

            var languageDescriptor = source.LanguageDescriptorEnum.GetValueOrDefault();

            var studentLanguage = new StudentLanguage
            {
                LanguageDescriptorId = (int) languageDescriptor
            };

            studentLanguage.StudentLanguageUses.Add(new StudentLanguageUse
            {
                LanguageDescriptorId = (int) languageDescriptor,
                LanguageUseTypeId = HomeLanguageTypeId
            });

            target.StudentLanguages.Add(studentLanguage);
        }

        private static void SetStudentAddress(EnrollmentModel source, Data.Entities.Student target)
        {
            
            target.StudentAddresses.Add(new StudentAddress
            {
                AddressTypeId = HomeAddressTypeId,
                StreetNumberName = source.StreetNumberName,
                ApartmentRoomSuiteNumber = source.ApartmentRoomSuiteNumber,
                City = source.City,
                PostalCode = source.PostalCode,
                StateAbbreviationTypeId = (int) source.StateAbbreviationTypeEnum.GetValueOrDefault()
            });
        }
    }
}