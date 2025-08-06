using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex() { Real = 1, Imaginary = 2};
            Complex b = new Complex() { Real = 4, Imaginary = 8};
            Complex c = a + b;
        }
    }
}
