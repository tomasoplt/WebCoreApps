using System;

namespace WebCoreApp.Services.Dto
{
    public class DepartmentDto
    {
        public int DepartmentID { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
