using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create three objects for Employee
            Employee employee = new Employee(1,"Denis", "Manager");
            Employee employee2 = new Employee(2,"Anton", "Asst.Manager");
            Employee employee3 = new Employee(3,"Anna","Clerk");
            Employee employee4 = new Employee() { id = 4, name = "Allen", job = "Executive" };

            // display fields
            Console.WriteLine(Employee.companyName);

            Console.WriteLine("First employee: ");
            Console.WriteLine(employee.id);
            Console.WriteLine(employee.name);
            Console.WriteLine(employee.job);
            Console.WriteLine();

            Console.WriteLine("Second employee: ");
            Console.WriteLine(employee2.id);
            Console.WriteLine(employee2.name);
            Console.WriteLine(employee2.job);
            Console.WriteLine();

            Console.WriteLine("Thid employee: ");
            Console.WriteLine(employee3.id);
            Console.WriteLine(employee3.name);
            Console.WriteLine(employee3.job);
            Console.WriteLine();
        }
    }
}
