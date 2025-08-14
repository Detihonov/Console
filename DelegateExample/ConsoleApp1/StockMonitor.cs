using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StockMonitor
    {
        public delegate void PriceChange(int price);
        public PriceChange PriceChangeHandler { get; set; }

        public void Start()
        {
            while (true)
            {
                int bankOfAmericaPrice = new Random().Next(100);

                PriceChangeHandler(bankOfAmericaPrice);
                Thread.Sleep(2000);
            }
        }

        public void ShowPrice(int price)
        {
            Console.WriteLine($"New price is: {price}");

        }
    }
}
