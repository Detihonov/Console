using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Products
    {
        private int productID;
        private string productName;
        public double cost;
        public double tax;
        public int quantityInStock;
        public static int totalNoProducts;
        public const string categoryName = "Electronics";
        public readonly string dateOfPurchase;

        // Constructor
        public Products()
        {
            dateOfPurchase = System.DateTime.Now.ToLongDateString();
        }

        // Set method for Product ID
        public void SetProductID(int value)
        {
            productID = value;
        }

        // Get method for Product ID
        public int GetProductID()
        {
            return productID;
        }

        // Set method for ProductName
        public void SetProductName(string value)
        {
            productName = value;
        }

        // Get method for ProductName
        public string GetProductName()
        {
            return productName;
        }

        // Method CalculateTax
        public void CalculateTax()
        {
            double t;

            // Calculate tax
            if (cost <= 20000)
            {
                t = cost * 10 / 100;
            }
            else
            {

                t = cost * 12.5 / 100;
            }
            tax = t;
        }
    }
}

