﻿using NGL.Web.Data.Entities;

namespace NGL.Web.Models.Enrollment
{
    public class ParentEnrollmentInfoModelToParentMapper : IMapper<ParentEnrollmentInfoModel, Parent>
    {
        public void Map(ParentEnrollmentInfoModel source, Parent target)
        {
            target.FirstName = source.FirstName;
            target.LastSurname = source.LastName;
            target.SexTypeId = (int) source.SexTypeEnum;
        }
    }
}