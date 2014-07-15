﻿using System.ComponentModel.DataAnnotations;

namespace NGL.Web.Models.ClassPeriod
{
    public class CreateModel
    {
        [Required]
        [StringLength(20)]
        public string ClassPeriodName { get; set; }
    }
}