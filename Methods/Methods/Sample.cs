using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Sample
    {
        public double Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        /// <summary>
        /// Передайте 32-битное целое число, и оно будет преобразовано
        ///  в его порядковый эквивалент.
        /// </summary>
        ///  <param name="number">Number is a cardinal value e.g. 1, 2, 3 and so on.</param>
        ///  <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd and so on.</returns>
        public void CardinalToOrdinal()
        {
            for (int number = 1; number < 10; number++)
            {
                Console.WriteLine($"CardinalToOrdinal {number}");
            }
        }
    }
}
