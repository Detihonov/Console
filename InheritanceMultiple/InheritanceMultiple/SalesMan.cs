using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMultiple
{
    public class SalesMan : IEmployee, IPerson
    {
        // field
        private int _id;
        private string _name;
        private string _location;
        private string _region;
        private DateTime _dateOfBirth;

        // properties
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Location { get => _location; set => _location = value; }
        public string Region { get => _region; set => _region = value; }
        public DateTime DateOfBirth { get => _dateOfBirth ; set => _dateOfBirth = value; }

        // constructor
        public SalesMan(int id, string name, string location, string region, DateTime date)
        {
            _id = id;
            _name = name;
            _location = location;
            _region = region;
            _dateOfBirth = date;
        }

        // metod
        public int GetAge()
        {
            throw new NotImplementedException();
        }

        public string GetHealthInsuranceAmount()
        {
            throw new NotImplementedException();
        }
    }
}
