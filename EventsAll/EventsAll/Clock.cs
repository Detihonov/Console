using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAll
{
    internal class Clock
    {
        private event Action Tick;
        private System.Timers.Timer timer;

        public Clock()
        {

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += (s, e) => Tick.Invoke();
        }

        public void Print()
        {
            Tick += () => Console.WriteLine($"Тик {DateTime.Now}");
            Start();
            Console.ReadKey();
            Stop();
            Console.WriteLine("Таймер остановлен");
        }

        private void Start() => timer.Start();
        private void Stop() => timer.Stop();
    }
}
