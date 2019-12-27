using System;
using System.ComponentModel.DataAnnotations;

namespace WebCoreApp.Services.Dto
{
    public class DepartmentDto
    {
        public int DepartmentID { get; set; }
        
        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
