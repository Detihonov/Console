using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    public class SalesMan : IEmployee
    {
        private int _id;
        private string _name;
        private string _location;
        private string _region;
        public int Id { get => _id;
            set
            {
                if (value >= 1 && value <= 2000)
                {
                    _id = value;
                }
            }
        }

        public string Name { get => _name; set => _name = value; }
        public string Location { get => _location; set => _location = value; }
        public string Region { get => _region; set => _region = value; }

        // constructor
        public SalesMan(int id, string name, string location, string region)
        {
            _id = id;
            _name = name;
            _location = location;
            _region = region;
        }

        // method implementation the abstract methods
        public string GetHealthInsuranceAmount()
        {
            return "Additional Health Insurance premium amount is: 1500";
        }
    }
}
