using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Stats
    {
        delegate void StatsCallback(int value, string name);

        private int _damage = 31;
        private int _aqility = 10;
        private int _strength = 10;
    }
}
