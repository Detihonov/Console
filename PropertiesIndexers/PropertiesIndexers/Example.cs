using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexers
{
    public class Example
    {
        // instance fields
        private int _id;
        private string _name;
        private string _job;
        private double _salary;
        private double _tax;

        // instance property
        public int Id 
        { 
            get
            { 
                return _id;
            } 
            set 
            { 
                if (value > 0)
                {
                    _id = value; 
                }
            }
        }
        public string Name { get { return _name; } set { _name = value; } }
        public string Job { get { return _job; } set { _job = value; } }
        
        // readonly property
        public double Salary { get { return _salary; } }
        
        // writeonly property
        public double Tax 
        { 
            set 
            { 
                if (value >= 0)
                {
                    _tax = value;
                }
            } 
        }

        // static field
        private static string _companyName;

        // static property
        public static string CompanyName 
        { 
            get 
            { 
                return _companyName; 
            } 
            set 
            { 
                if(value.Length <= 20)
                {
                    _companyName = value;
                }
            }
        }
    }
}
