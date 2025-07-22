using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create three objects for Example
            Example example = new Example();
            Example example2 = new Example();
            Example example3 = new Example();

            example.Id = 1;
            example.Name = "Scott";
            example.Job = "Manager";
            example.Tax = 13;
            example.NativePlace = "Moskov";

            example2.Id = 2;
            example2.Name = "Allen";
            example2.Job = "Asst.Manager";
            example2.Tax = 50;
            example2.NativePlace = "New Delhi";

            example3.Id = 3;
            example3.Name = "Anna";
            example3.Job = "Clerk";
            example3.Tax = 15;
            example3.NativePlace = "New York";

            // create car object
            Car car = new Car();

            // display fields
            Console.WriteLine(Example.CompanyName);
            Console.WriteLine("\nFirst Example: ");
            Console.WriteLine(example.Id);
            Console.WriteLine(example.Name);
            Console.WriteLine(example.Job);
            Console.WriteLine(example.Salary);
            Console.WriteLine(example.CalculateSalary());
            Console.WriteLine(example.NativePlace);
            Console.WriteLine();

            Console.WriteLine("\nSecond Example: ");
            Console.WriteLine(example2.Id);
            Console.WriteLine(example2.Name);
            Console.WriteLine(example2.Job);
            Console.WriteLine(example2.Salary);
            Console.WriteLine(example2.NativePlace);
            Console.WriteLine();

            Console.WriteLine("\nThird Example: ");
            Console.WriteLine(example3.Id);
            Console.WriteLine(example3.Name);
            Console.WriteLine(example3.Job);
            Console.WriteLine(example3.Salary);
            Console.WriteLine(example3.NativePlace);
            Console.WriteLine();

            //Object Car
            car[0] = "Nissan";

            // Display Car
            Console.WriteLine("First Car: ");
            Console.WriteLine(car[0]); // Nissan 
            Console.WriteLine(car["second"]);
            Console.WriteLine(car[2]);
        }
    }
}
