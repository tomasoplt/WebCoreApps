using System;
using System.ComponentModel.DataAnnotations;
using WebCoreApp.Services.Infrastructure.Validators;

namespace WebCoreApp.Services.Dto
{
    public class DepartmentDto
    {
        public int DepartmentID { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required]
        [ValidDepartmentName(ErrorMessage = "Department name must start with letter 'D'")]
        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
