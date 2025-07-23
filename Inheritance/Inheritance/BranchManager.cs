using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BranchManager:Manager
    {
        // constructor of child class
        public BranchManager(int id, string name, string location, string deportmentName) : base(id, name, location, deportmentName)
        {
            
        }

    }
}
