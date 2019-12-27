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
        private readonly IUnitOfWork _uow;

        public DepartmentService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public DepartmentDto GetDepartment(int id)
        {
            return _uow.Repository<Department>().Single(x => x.DepartmentID == id).ToDepartmentDto();
        }

        public List<DepartmentDto> GetDepartments()
        {
            var departments = _uow.Repository<Department>().Get().Select(x => x.ToDepartmentDto()).ToList();
            return departments;
        }

        public void Update(DepartmentDto department)
        {
            Department dbObject = _uow.Repository<Department>().Single(x => x.DepartmentID == department.DepartmentID);
            dbObject.Name = department.Name;
            dbObject.InstructorID = department.InstructorID;
            dbObject.StartDate = department.StartDate;
            dbObject.Budget = department.Budget;

            _uow.Repository<Department>().Update(dbObject);
            _uow.Save();
        }
    }
}
