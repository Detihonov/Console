using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexers
{
    public class Example
    {
        // Modifier Metods
        // 1.Private 2.Protected 3.Private protected
        // 4.Internal 5.Protected internal 6.Public

        // Modifier Fields
        // 1.Static 2.Virtual 3.Abstract
        // 4.Override 5.New 6.Sealed

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
                if (value >= 0 && value <= 100)
                {
                    _tax = value;
                }
            } 
        }

        // method CalculateTax
        public double CalculateSalary()
        {
            double tax = Salary - _tax;
            return tax;
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

        // automatic properties
        public string NativePlace { get; set; }

        // default constructor
        public Example()
        {
            _salary = 1000;
        }

        // instance constructor
        public Example(int id, string name, string job)
        {
            _id=id;
            _name=name;
            _job=job;
            _salary= 1000;
        }

        // constructor 2
        public Example(int id, string name)
        {
            _id=id;
            _name=name;
            _salary = 1000;
        }

        // static constructor
        static Example()
        {
            _companyName = "ABC Industries";
        }
    }
}
