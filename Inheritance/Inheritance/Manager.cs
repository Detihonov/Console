namespace Inheritance
{
    public class Manager:Employee
    {
        // field
        private string _deportmentName;

        // property
        public string DeportamentName 
        { 
            get
            {
                return _deportmentName;
            }
            set
            {
                _deportmentName = value;
            }
        }

        // constructor of child class
        public Manager(int id, string name, string location, string deportmentName): base(id, name, location)
        {
            _deportmentName = deportmentName;
        }

        // method GetTotalSalesOfTheYear
        public long GetTotalSalesOfTheYear()
        {
            return 10_000;
        }

        // metod GetFullDepartmentName + key base
        public string GetFullDepartmentName()
        {
            return DeportamentName + " at " + base._location;
        }
    }
}
