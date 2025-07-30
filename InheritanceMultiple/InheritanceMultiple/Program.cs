using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson person;
            person = new Manager(1,"Alien","New York","Account",Convert.ToDateTime("13-06-1985"));
            Console.WriteLine();
            Console.WriteLine(person.GetAge());

            IEmployee emp;
            emp = new Manager(1, "Alien", "New York", "Account", Convert.ToDateTime("13-06-1985"));
            Console.WriteLine();
            Console.WriteLine(emp.GetAge());
        }
    }
}
