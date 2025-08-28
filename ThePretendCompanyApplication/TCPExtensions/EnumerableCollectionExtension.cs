using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCPData;

namespace TCPExtensions
{
    public static class EnumerableCollectionExtension
    {
        public static IEnumerable<Employee> GetHighSalariedEmployees(this IEnumerable<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"Accessing employee: {emp.FirstName + " " + emp.LastName}");
                if (emp.AnnualSalary >= 50000)
                    yield return emp;
            }
        }
    }
}
