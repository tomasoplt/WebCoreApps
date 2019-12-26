using System;
using System.ComponentModel.DataAnnotations;
using WebCoreApp.EF.Models;

namespace WebCoreApp.Services.Dto
{
    public class CourseDto
    {
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        [Display(Name = "Department ID")]
        public int DepartmentID { get; set; }
        
        [Display(Name = "Department")]
        public Department Department { get; set; }
    }
}
