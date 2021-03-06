﻿using System.Linq;
using Castle.Core.Internal;
using Humanizer;
using NGL.Web.Data.Entities;

namespace NGL.Web.Models.Student
{
    public class ParentToProfileParentModelMapper : MapperBase<Parent, EditProfileParentModel>
    {
        private readonly ParentToProfileParentAddressModelMapper _parentAddressMapper;

        public ParentToProfileParentModelMapper(ParentToProfileParentAddressModelMapper parentAddressMapper)
        {
            _parentAddressMapper = parentAddressMapper;
        }

        public override void Map(Parent source, EditProfileParentModel target)
        {
            var studentParentAssociation = source.StudentParentAssociations.First();
            target.ParentUSI = source.ParentUSI;
            target.FirstName = source.FirstName;
            target.LastName = source.LastSurname;
            target.Sex = (SexTypeEnum) source.SexTypeId;
            target.Relationship = (RelationTypeEnum) studentParentAssociation.RelationTypeId;
            target.RelationshipForDisplay = ((RelationTypeEnum) studentParentAssociation.RelationTypeId).Humanize();
            target.TelephoneNumber = source.ParentTelephones.First().TelephoneNumber;
            if (!source.ParentElectronicMails.IsNullOrEmpty())
                target.EmailAddress = source.ParentElectronicMails.First().ElectronicMailAddress; 

            target.SameAddressAsStudent = studentParentAssociation.LivesWith.GetValueOrDefault();

            if (studentParentAssociation.LivesWith == false)
            {
                target.EditableParentAddressModel = _parentAddressMapper.Build(source);
            }
            else
            {
                target.EditableParentAddressModel = new EditableParentAddressModel();
            }
        }
    }
}