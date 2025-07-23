using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Seller:Employee
    {
		// field
		private string _region;

		// properties
		public string Region
		{
			get { return _region; }
			set { _region = value; }
		}

		// Metod
		public long GetSalesOfTheCurrentMomth()
		{
			return 1_000;	
		}

	}
}
