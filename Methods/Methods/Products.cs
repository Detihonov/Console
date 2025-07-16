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
        private double cost;
        private double tax;
        private int quantityInStock;
        private static int totalNoProducts;
        private const string categoryName = "Electronics";
        private readonly string dateOfPurchase;

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

        // Set method for Cost
        public void SetCost(double value)
        {
            cost = value;
        }

        // Get method for Cost
        public double GetCost()
        {
            return cost;
        }

        // Set method for Tax
        public void SetTax(double value)
        {
            tax = value;
        }

        // Get method for Tax
        public double GetTax()
        {
            return tax;
        }

        // Set method for quantityInStock
        public void SetQuantityInStock(int value)
        {
            quantityInStock = value;
        }

        // Get method for quantityInStock
        public int GetQuantityInStock()
        {
            return quantityInStock;
        }

        // Method CalculateTax
        // in 
        public void CalculateTax(in double percent = 4.5)
        {
            double t;

            // Calculate tax
            if (cost <= 20000)
            {
                t = cost * 10 / 100;
            }
            else
            {

                t = cost * percent / 100;
            }
            tax = t;
        }

        // Method Overloading
        // MethodName();
        // MethodName(int);
        // MethodName(string);
        // MethodName(int, string);
        // MethodName(string, int);
        // MethodName(int, string, double);

        // ref
        public void CalculateTax(ref double cost, ref double percent)
        {

            double t;

            // Calculate tax
            if (cost <= 50000)
            {
                t = cost * 5 / 100;
            }
            else
            {

                t = cost * percent / 100;
            }
            tax = t;
        }

        // Get method for dateOfPurchase
        public string GetDateOfPurchase()
        {
            return dateOfPurchase;
        }

        // out
        public void CalculateTaxOut(out double percent)
        {
            percent = 10;
            double t;

            // Calculate tax
            if (cost <= 20000)
            {
                t = cost * 10 / 100;
            }
            else
            {

                t = cost * percent / 100;
            }
            tax = t;
        }

        // Set metod for TotalNoProducts
        public static void SetTotalNoProducts(int value)
        {
            totalNoProducts = value;
        }

        // Get metod for TotalNoProducts
        public static int GetTotalNoProducts()
        {
            return totalNoProducts;
        }

        // Get metod static for categoryName
        public static string GetCategoryName()
        {
            return categoryName;
        }

        // static metod CalculateTotalQuantity
        public static int GetTotalQuantity(Products product1, Products product2, Products product3)
        {
            int total = 0;
            total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
            return total;
        }
    }
}

