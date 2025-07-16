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
            Products.SetTotalNoProducts(Products.GetTotalNoProducts()+1); // 1
            Products products2 = new Products();
            Products.SetTotalNoProducts(Products.GetTotalNoProducts()+1); // 2
            Products products3 = new Products();
            Products.SetTotalNoProducts(Products.GetTotalNoProducts()+1); // 3

            // Initalize fields
            products1.SetProductID(1001);
            products1.SetProductName("Mobile");
            products1.SetCost(20000);
            products1.SetQuantityInStock(1200);

            products2.SetProductID(1002);
            products2.SetProductName("Laptor");
            products2.SetCost(45000);
            products2.SetQuantityInStock(3400);

            products3.SetProductID(1003);
            products3.SetProductName("Speakers");
            products3.SetCost(36000);
            products3.SetQuantityInStock(800);

            // Call metod CalculateTax()
            products1.CalculateTax(percent:9.2);
            products2.CalculateTax(7.4);
            products3.CalculateTax(10000,3.4);

            // Get values from fields
            Console.WriteLine("Product 1: ");
            Console.WriteLine("Product ID: " + products1.GetProductID());
            Console.WriteLine("Product Name: " + products1.GetProductName());
            Console.WriteLine("Cost: " + products1.GetCost());
            Console.WriteLine("Quantity in Stock: " + products1.GetQuantityInStock());
            Console.WriteLine("Date of Purchase: " + products1.GetDateOfPurchase());
            Console.WriteLine("Tax: " + products1.GetTax());

            Console.WriteLine("\nProduct 2: ");
            Console.WriteLine("Product ID: " + products2.GetProductID());
            Console.WriteLine("Product Name: " + products2.GetProductName());
            Console.WriteLine("Cost: " + products2.GetCost());
            Console.WriteLine("Quantity in Stock: " + products2.GetQuantityInStock());
            Console.WriteLine("Date of Purchase: " + products2.GetDateOfPurchase());
            Console.WriteLine("Tax: " + products2.GetTax());

            Console.WriteLine("\nProduct 3: ");
            Console.WriteLine("Product ID: " + products3.GetProductID());
            Console.WriteLine("Product Name: " + products3.GetProductName());
            Console.WriteLine("Cost: " + products3.GetCost());
            Console.WriteLine("Quantity in SStock: " + products3.GetQuantityInStock());
            Console.WriteLine("Data of Purchase: " + products3.GetDateOfPurchase());
            Console.WriteLine("Tax: " + products3.GetTax());

            // Total Quantity
            int totalQuantity = Products.GetTotalQuantity(products1, products2, products3);

            Console.WriteLine("\nTotal Quantity: " + totalQuantity);
            Console.WriteLine("Total no. of product: " + Products.GetTotalNoProducts()); // 3
            Console.WriteLine("Category of products: " + Products.GetCategoryName()); // Electronics
        }


    }
}
