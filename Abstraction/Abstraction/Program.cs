using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // abstract class
            Employee employee;

            // One child class
            employee = new Manager(1, "Denis", "Russia", "Developer");
            Console.WriteLine(employee.GetHealthInsuranceAmount());
            Console.WriteLine();

            // Two chilld class
            employee = new SalesMan(2,"Michal","New York","Manager");
            Console.WriteLine(employee.GetHealthInsuranceAmount());

        }
    }
}
