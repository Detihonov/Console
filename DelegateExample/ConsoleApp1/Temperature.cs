 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Temperature
    {
        public static void TemperaturePrint()
        {
            Console.WriteLine("\nTemperature °C: ");

            // использование
            var monitor = new TemperatureMonitor();

            // подписка на событие Action
            monitor.TemperatureWarning += message => Console.WriteLine(message);

            // подписка на событие Func
            monitor.TemperatureFormater += temp => $"{temp}°C";

            // проверка температуры
            monitor.CheckTemperature(25);
            monitor.CheckTemperature(35);
        }
    }
}
