using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    public class Manager : IEmployee
    {
        // field
        private int _id;
        private string _name;
        private string _location;
        private string _department;
        
        // properties
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Location { get => _location; set => _location = value; }
        public string Department { get => _department; set => _department = value; }

        // constructor
        public Manager(int id, string name, string location, string department)
        {
            _id = id;
            _name = name;
            _location = location;
            _department = department;
        }

        // method implementation of the interface methods
        public string GetHealthInsuranceAmount()
        {
            return "Additional Health Insurance premium amount is: 1000";
        }
    }
}
