using System;
using System.ComponentModel.DataAnnotations;

namespace WebCoreApp.Services.Dto
{
    public class DepartmentDto
    {
        public int DepartmentID { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
