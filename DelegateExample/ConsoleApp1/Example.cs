using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Example
    {
        public int AddInt(int x, int y)
        {
            return x + y;
        }

        public double AddDouble(double x, double y)
        {
            return (double)x + y;
        }

        public static char AddChar(char x, char y)
        {
            return (char)(x + y);
        }
    }
}
