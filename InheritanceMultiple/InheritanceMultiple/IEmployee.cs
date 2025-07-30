using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMultiple
{
    interface IEmployee
    {
        // auto-properties
        int Id { get; set; }
        string Name { get; set; }
        string Location {  get; set; }

        // method abstract
        string GetHealthInsuranceAmount();
        int GetAge();
    }
}
