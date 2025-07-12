using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Objects
            Products products1 = new Products();
            Products.totalNoProducts++;
            Products products2 = new Products();
            Products.totalNoProducts++;
            Products products3 = new Products();
            Products.totalNoProducts++;

            // Initalize fields
            products1.productID = 1001;
            products1.productName = "Mobile";
            products1.cost = 20000;
            products1.quantityInStock = 1200;

            products2.productID = 1003;
            products2.productName = "Laptor";
            products2.cost = 45000;
            products2.quantityInStock = 3400;

            products3.productID = 1002;
            products3.productName = "Speakers";
            products3.cost = 36000;
            products3.quantityInStock = 800;

            // Get values from fields
            Console.WriteLine("Product 1: ");
            Console.WriteLine("Product ID: " + products1.productID);
            Console.WriteLine("Product Name: " + products1.productName);
            Console.WriteLine("Cost: " + products1.cost);
            Console.WriteLine("Quantity in Stock: " + products1.quantityInStock);
            Console.WriteLine("Date of Purchase: " + products1.dateOfPurchase);

            Console.WriteLine("\nProduct 2: ");
            Console.WriteLine("Product ID: " + products2.productID);
            Console.WriteLine("Product Name: " + products2.productName);
            Console.WriteLine("Cost: " + products2.cost);
            Console.WriteLine("Quantity in Stock: " + products2.quantityInStock);
            Console.WriteLine("Date of Purchase: " + products2.dateOfPurchase);

            Console.WriteLine("\nProduct 3: ");
            Console.WriteLine("Product ID: " + products3.productID);
            Console.WriteLine("Product Name: " + products3.productName);
            Console.WriteLine("Cost: " + products3.cost);
            Console.WriteLine("Quantity in SStock: " + products3.quantityInStock);
            Console.WriteLine("Data of Purchase: " + products3.dateOfPurchase);
        }


    }
}
