using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class SalesMan:Employee
    {
        // field
        private string _region;

        // properties
        public string Region { get { return _region; } }

        public SalesMan(int id,string name, string location, string region):base(id,name,location)
        {
            _region = region;
        }

        // method overriding the abstract
        public override string GetHealthInsuranceAmount()
        {
            return "Additional Health Insurance premium amount is: 1500";
        }
    }
}
