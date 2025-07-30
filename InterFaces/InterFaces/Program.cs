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
            IEmployee emp;
            emp = new Manager(1,"Alien","New York","Accounting");
            //Console.WriteLine(emp.Id);
            //Console.WriteLine(emp.Name);
            //Console.WriteLine(emp.Location);
            Console.WriteLine(emp.GetHealthInsuranceAmount());
            Console.WriteLine();

            emp = new SalesMan(2,"John","Washiington","East");
            //Console.WriteLine(sales.Id);
            //Console.WriteLine(sales.Name);
            //Console.WriteLine(sales.Location);
            //Console.WriteLine(sales.Region);
            Console.WriteLine(emp.GetHealthInsuranceAmount());

        }
    }
}
