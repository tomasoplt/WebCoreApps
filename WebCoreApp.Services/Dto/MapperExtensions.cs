﻿using WebCoreApp.EF.Models;

namespace WebCoreApp.Services.Dto
{
    public static class MapperExtensions
    {
        public static DepartmentDto ToDepartment(this Department department)
        {
            return new DepartmentDto
            {
                DepartmentID = department.DepartmentID,
                Name = department.Name,
                Budget = department.Budget,
                InstructorID = department.InstructorID,
                StartDate = department.StartDate,
                RowVersion = department.RowVersion
            };
        }
    }
}
