﻿namespace Inheritance
{
    public class Employee
    {
        // fields
        private int _id;
        private string _name;
        protected string _location;

        // properties
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Location { get { return _location; } set { _location = value; } }

        // constructor of parent class
        public Employee(int id, string name, string location)
        {
            _id = id;
            _name = name;
            _location = location;
        }

        // Method GetHealthInsuranceAmount
        public string GetHealthInsuranceAmount()
        {
            return "Health Insurance amount is: " + 500;
        }

        public void MethodNameOne()
        {
           
        }

        // virtual metod MethodName
        public virtual string MethodName()
        {
            return "Health Insurance premium amount is: " + 500;
        }

        public virtual void MethodNameTwo()
        {

        }
    }
}
