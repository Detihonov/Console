namespace Inheritance
{
	// sealed 
    public sealed class Seller:Employee
    {
		// field
		private string _region;

		// properties
		public string Region
		{
			get { return _region; }
			set { _region = value; }
		}

        // constructor of child class
        public Seller(int id, string name, string location, string region):base(id, name, location)
        {
            _region = region;
        }

        // Metod GetSalesOfTheCurrentMomth
        public long GetSalesOfTheCurrentMomth()
		{
			return 1_000;
		}

        public sealed override string MethodName()
        {
            return "Health Insurance premium amount is: " + 500;
        }

    }
}
