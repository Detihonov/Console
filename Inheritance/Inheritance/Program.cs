﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create object of Employee
            Employee employee = new Employee(1,"Scott", "Hyderbad");

            Console.WriteLine("Object of Parent class (Employee): ");
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Location);
            Console.WriteLine();

            // create object of Manager
            Manager manager = new Manager(2,"Denis","Moskow", "Accounting");

            Console.WriteLine("Object of Child class (Manager): ");
            Console.WriteLine(manager.Id);
            Console.WriteLine(manager.Name);
            Console.WriteLine(manager.Location);
            Console.WriteLine(manager.DeportamentName);
            Console.WriteLine(manager.GetTotalSalesOfTheYear());
            Console.WriteLine(manager.GetFullDepartmentName());
            Console.WriteLine(manager.GetHealthInsuranceAmount());
            Console.WriteLine(manager.MethodName());
            Console.WriteLine();

            // create object of Seller
            Seller seller = new Seller(3,"Alien", "Washington", "East");

            Console.WriteLine("Object of Child class (Seller): ");
            Console.WriteLine(seller.Id);
            Console.WriteLine(seller.Name);
            Console.WriteLine(seller.Location);
            Console.WriteLine(seller.Region);
            Console.WriteLine(seller.GetSalesOfTheCurrentMomth());
            Console.WriteLine();
        }
    }
}
