using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Products
    {
        private int id;
        public int ProductID { get; set; } = 0;
        public string ProductName { get; set; }
        public double Tax { get; set; }
        public double Cost { get; set; }
        public readonly string DateOfPurchase;

        public Products()
        {
            DateOfPurchase = System.DateTime.Now.ToLongDateString();
        }
    }
}

