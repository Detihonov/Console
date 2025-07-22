using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexers
{
    public class Car
    {
        // private field
        private string[] _brands = new string[] { "BMW", "Skoda", "Honda" };
        private string[] _names = new string[] { "first", "second", "third" };

        // public indexer int
        public string this[int index]
        {
            set
            {
                this._brands[index] = value;
            }
            get { return this._brands[index];}
        }

        // public indexer string
        public string this[string name]
        {
            set
            {
                this._brands[Array.IndexOf(_names, name)] = value;
            }
            get
            {
                return _brands[Array.IndexOf(_names, name)];
            }
        }
    }
}
