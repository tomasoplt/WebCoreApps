using Net.Core.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using WebCoreApp.EF.Models;
using WebCoreApp.Services.Dto;

namespace WebCoreApp.Product.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IRepository<Department> _repository;

        public DepartmentService(IRepository<Department> repository)
        {
            _repository = repository;
        }

        public List<DepartmentDto> GetDepartments()
        {
            var departments = _repository.Get().Select(x => new DepartmentDto()
            {
                DepartmentID = x.DepartmentID,
                Name = x.Name,
                Budget = x.Budget,
                StartDate = x.StartDate,
                InstructorID = x.InstructorID,
                RowVersion = x.RowVersion
            }).ToList();

            return departments;
        }
    }
}
