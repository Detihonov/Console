using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMultiple
{
    public class Manager : IEmployee, IPerson
    {
        // field
        private int _id;
        private string _name;
        private string _location;
        private string _department;
        private DateTime _dateOfBirth;

        // properties
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Location { get => _location; set => _location = value; }
        public string Department { get => _department; set => _department = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        int IEmployee.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployee.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployee.Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Manager(int id, string name, string location, string department, DateTime dateOfBirth)
        {
            _id = id;
            _name = name;
            _location = location;
            _department = department;
            _dateOfBirth = dateOfBirth;
        }

        public long GetTotalSalesOfTheYear()
        {
            return 1000;
        }

        public string GetFullDepartmentName()
        {
            return Department + " at " + _location;
        }

        // method for IPerson.GetAge method
        int IPerson.GetAge()
        {
            int age = Convert.ToInt32((DateTime.Now - DateOfBirth).TotalDays / 365);
            return age;
        }

        string IEmployee.GetHealthInsuranceAmount()
        {
            throw new NotImplementedException();
        }

        // method for IEmployee.GetAge method
        int IEmployee.GetAge()
        {
            return 20;
        }
    }
}
