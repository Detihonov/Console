using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPData;
using TCPExtensions;

namespace ThePretendCompanyApplication
{
    public static class Example
    {
        static void PrintResultList()
        {
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            var filteredEmployee = employees.Where(emp => emp.IsManager == true);
            var filteredDapartment = departments.Where(dep => dep.ShortName == "HR" || dep.ShortName == "FN");

            var resultList = from emp in employees
                             join dept in departments
                             on emp.DepartmentId equals dept.Id
                             select new
                             {
                                 FirtsName = emp.FirstName,
                                 LastName = emp.LastName,
                                 AnnualSalary = emp.AnnualSalary,
                                 Manager = emp.IsManager,
                                 Department = dept.LongName
                             };

            var averageAnnualSalary = resultList.Average(x => x.AnnualSalary);
            var highestAnnualSalary = resultList.Max(x => x.AnnualSalary);
            var lowestAnnualSalary = resultList.Min(x => x.AnnualSalary);

            foreach (var emp in resultList)
            {
                Console.WriteLine("Average Annual Salary: " + averageAnnualSalary);
                Console.WriteLine("Highest Annual Salary: " + highestAnnualSalary);
                Console.WriteLine("Lowest Annual Salary: " + lowestAnnualSalary);
                Console.WriteLine();
            }
        }

        public static void PrintSelectList()
        {
            List<Employee> employeesList = Data.GetEmployees();
            List<Department> departmentsList = Data.GetDepartments();

            // Select and Where Operators - Method Syntax 
            var results = employeesList.Select(e => new
            {
                FullName = e.FirstName + " " + e.LastName,
                AnnualSalary = e.AnnualSalary,
            }).Where(e => e.AnnualSalary >= 50000);

            foreach (var res in results)
            {
                Console.WriteLine($"{res.FullName,-20} {res.AnnualSalary,10}");
            }

            Console.WriteLine();

            // Select and Where Operators - Query Syntax
            var resultsSql = from emp in employeesList
                             where emp.AnnualSalary >= 50000
                             select new
                             {
                                 FullName = emp.FirstName + " " + emp.LastName,
                                 AnnualSalary = emp.AnnualSalary
                             };

            foreach (var res in resultsSql)
            {
                Console.WriteLine($"{res.FullName,-20} {res.AnnualSalary,10}");
            }
        }

        public static void GetHighSalariedEmployees()
        {
            List<Employee> employeesList = Data.GetEmployees();
            List<Department> departmentsList = Data.GetDepartments();

            //Deferred Exucution Example 
            var results = from emp in employeesList.GetHighSalariedEmployees()
                          select new
                          {
                              FullName = emp.FirstName + " " + emp.LastName,
                              AnnualSalary = emp.AnnualSalary
                          };

            foreach (var result in results)
            {
                Console.WriteLine($"{result.FullName,-20} {result.AnnualSalary,10}");
            }

            Console.WriteLine();

            // Immediate Execution Example
            var res = (from emp in employeesList.GetHighSalariedEmployees()
                       select new
                       {
                           FullName = emp.FirstName + " " + emp.LastName,
                           AnnualSalary = emp.AnnualSalary
                       }).ToList();

            foreach (var result in res)
            {
                Console.WriteLine($"{result.FullName,-20} {result.AnnualSalary,10}");
            }

        }
    }
}
