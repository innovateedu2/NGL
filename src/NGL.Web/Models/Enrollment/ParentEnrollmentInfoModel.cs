﻿using System;
using System.ComponentModel.DataAnnotations;
using NGL.Web.Data.Entities;

namespace NGL.Web.Models.Enrollment
{
    public class ParentEnrollmentInfoModel
    {
        [Display(Name = "Parent USI")]
        [Required]
        public int? ParentUsi { get; set; }

        [Display(Name = "Guardian First Name")]
        [Required]
        [StringLength(75)]
        public String ParentFirstName { get; set; }

        [Display(Name = "Guardian Last Name")]
        [Required]
        [StringLength(75)]
        public String ParentLastName { get; set; }

//        [Display(Name = "Relationship To Student")]
//        [Required]
//        public RelationTypeEnum? RelationshipToStudent { get; set; }
//
//        [Display(Name = "Phone number")]
//        [StringLength(24)]
//        public String ParentPhoneNumber { get; set; }
//
//        [Display(Name = "Email Address")]
//        [StringLength(128)]
//        public String ParentEmailAddress { get; set; }

        [Display(Name = "Make this primary contact")]
        public bool IsPrimaryContact { get; set; }
       
        [Display(Name = "Sex")]
        [Required]
        public SexTypeEnum? SexTypeEnum { get; set; }

    }
}