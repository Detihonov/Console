using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TemperatureMonitor
    {
        public event Action<string> TemperatureWarning;
        public event Func<int, string> TemperatureFormater;
        // private event Action<string> TemperatureError;

        public void CheckTemperature(int temp)
        {
            if (temp > 30)
            {
                TemperatureWarning?.Invoke("Предупреждение: высокая температура!");
            }

            string formatted = TemperatureFormater?.Invoke(temp) ?? temp.ToString();
            Console.WriteLine($"Текущая температура: {formatted}");
        }
    }
}
