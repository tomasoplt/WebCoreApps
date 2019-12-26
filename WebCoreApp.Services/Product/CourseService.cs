using Net.Core.EF;
using System.Collections.Generic;
using System.Linq;
using WebCoreApp.EF.Models;
using WebCoreApp.Services.Dto;

namespace WebCoreApp.Product.Services
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> _repository;

        public CourseService(IRepository<Course> repository)
        {
            _repository = repository;
        }

        public List<CourseDto> GetCourses()
        {
            var courses = _repository.Get().Select(x => new CourseDto()
            {
                CourseID = x.CourseID,
                Department = x.Department,
                DepartmentID = x.DepartmentID,
                Title = x.Title
            }).ToList();

            return courses;
        }
    }
}
