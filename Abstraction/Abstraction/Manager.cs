using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Manager:Employee
    {
        // field
        private string _departmentName;

        // properties
        public string Department { get { return _departmentName; } set { _departmentName = value; } }

        // constructor of child class
        public Manager(int id, string name, string location, string departmentName):base (id,name,location)
        {
            _departmentName = departmentName;
        }

        // method overriding the abstract
        public override string GetHealthInsuranceAmount()
        {
            return "Additional Health Insurance premium amount is: 1000";
        }
    }
}
