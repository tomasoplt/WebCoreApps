
using EF.Core;

namespace WebCoreApp.EF.Models
{
    public class CourseAssignment : BaseEntity
    {
        public int InstructorID { get; set; }
        public int CourseID { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
