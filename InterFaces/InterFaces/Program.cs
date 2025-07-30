using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1,"Alien","New York","Accounting");
            Console.WriteLine(manager.Id);
            Console.WriteLine(manager.Name);
            Console.WriteLine(manager.Location);
            Console.WriteLine(manager.Department);
            Console.WriteLine(manager.GetHealthInsuranceAmount());
            Console.WriteLine();

            SalesMan sales = new SalesMan(2,"John","Washiington","East");
            Console.WriteLine(sales.Id);
            Console.WriteLine(sales.Name);
            Console.WriteLine(sales.Location);
            Console.WriteLine(sales.Region);
            Console.WriteLine(sales.GetHealthInsuranceAmount());

        }
    }
}
