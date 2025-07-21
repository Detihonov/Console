using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Employee
    {
        // field
        public int id;
        public string name;
        public string job;

        // static field
        public static string companyName;

        // constructor
        public Employee()
        {
            
        }

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Employee(int id, string name, string job)
        {
            this.id = id;
            this.name = name;
            this.job = job;
        }

        // Constructor only static
        static Employee()
        {
            companyName = "ABC Industries";
        }
    }
}
