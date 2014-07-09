﻿using Humanizer;
using NGL.Web.Data.Entities;

namespace NGL.Web.Models.Student
{
    public class StudentToProfileModelMapper : IMapper<Data.Entities.Student, ProfileModel>
    {
        public void Map(Data.Entities.Student source, ProfileModel target)
        {
            target.FirstName = source.FirstName;
            target.LastName = source.LastSurname;
            target.BirthDate = source.BirthDate;
            target.Race = ((OldEthnicityTypeEnum) source.OldEthnicityTypeId).Humanize();
            target.HispanicLatinoEthnicity = source.HispanicLatinoEthnicity;
            target.Sex = ((SexTypeEnum)source.SexTypeId).Humanize();
        }
    }
}