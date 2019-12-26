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

        public DepartmentDto GetDepartment(int id)
        {
            return _repository.Single(x => x.DepartmentID == id).ToDepartment();
        }

        public List<DepartmentDto> GetDepartments()
        {
            var departments = _repository.Get().Select(x => x.ToDepartment()).ToList();
            return departments;
        }
    }
}
