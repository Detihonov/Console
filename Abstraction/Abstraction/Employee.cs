using System;

namespace Abstraction
{
    // abstract class
    public abstract class Employee
    {
        // field
        private int _id;
        private string _name;
        private string _location;

        // properties
        public int Id { get { return _id; } set { _id = value; } }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Location { get { return _location; } set { _location = value; } }

        // constructor
        protected Employee(int id, string name, string location)
        {
            _id = id;
            _name = name;
            _location = location;
        }

        // abstract metods
        public abstract string GetHealthInsuranceAmount();
    }
}
