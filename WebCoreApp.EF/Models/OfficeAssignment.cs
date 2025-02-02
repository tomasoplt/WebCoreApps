﻿using EF.Core;
using System.ComponentModel.DataAnnotations;

namespace WebCoreApp.EF.Models
{
    public class OfficeAssignment : BaseEntity
    {
        [Key]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}
