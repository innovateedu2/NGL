﻿using System.ComponentModel.DataAnnotations;

namespace NGL.Web.Models.Student
{
    public class ProfileAcademicDetailModel
    {
        public decimal? ReadingScore { get; set; }
        public decimal? WritingScore { get; set; }
        public decimal? MathScore { get; set; }

        [Display(Name="Performance History")]
        public string PerformanceHistoryFileUrl { get; set; }

        public string PerformanceHistory { get; set; }
    }
}