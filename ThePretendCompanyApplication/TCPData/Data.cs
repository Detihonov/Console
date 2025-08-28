using System;
using System.Collections.Generic;

namespace TCPData
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {

            var employes = new List<Employee>()
            { 
                new Employee 
                { 
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Jones",
                    AnnualSalary = 60000.3m,
                    IsManager = true,
                    DepartmentId = 1,
                },

                new Employee()
                {
                    Id = 2,
                    FirstName = "Douglas",
                    LastName = "Roberts",
                    AnnualSalary = 80000.1m,
                    IsManager = true,
                    DepartmentId = 2
                },

                new Employee()
                {
                    Id = 3,
                    FirstName = "Douglas",
                    LastName = "Roberts",
                    AnnualSalary = 40000.2m,
                    IsManager = false,
                    DepartmentId = 2
                },

                new Employee()
                {
                    Id = 4,
                    FirstName = "Jane",
                    LastName = "Stevens",
                    AnnualSalary = 30000.4m,
                    IsManager = false,
                    DepartmentId = 3
                },

                new Employee()
                {
                    Id = 5,
                    FirstName = "Sam",
                    LastName = "Davis",
                    AnnualSalary = 100000.20m,
                    IsManager = true,
                    DepartmentId = 2
                }
            };

            return employes;
        }

        public static List<Department> GetDepartments()
        {
            var departments = new List<Department>()
            {
                new Department()
                {
                    Id = 1,
                    ShortName = "HR",
                    LongName = "Human Recources"
                },

                new Department()
                {
                    Id = 2,
                    ShortName = "FN",
                    LongName = "Finance",
                },

                new Department()
                {
                    Id = 3,
                    ShortName = "TE",
                    LongName = "Tecnology"
                }
            };

            return departments;
        }

    }
}
