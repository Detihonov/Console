using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Stats
    {
        public delegate void StatsCallback(int value, string name);

        private int _damage = 31;
        private int _aqility = 10;
        private int _strength = 13;

        public void ReturnStats(StatsCallback stattsCallback)
        {
            stattsCallback?.Invoke(_damage, " урона");
            stattsCallback?.Invoke(_aqility, " ловкости");
            stattsCallback?.Invoke(_strength, " силы");
        }

        public void Display(int value, string name)
        {
            Console.WriteLine(value + name);
        }
    }
}
