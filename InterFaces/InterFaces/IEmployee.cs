using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    interface IEmployee
    {
        // An interface can contain only abstract methods.

        // auto properties
        int Id { get; set; }
        string Name { get; set; }
        string Location { get; set; }

        // abstract metod
        string GetHealthInsuranceAmount();
    }
}
