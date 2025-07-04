using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskArrayPositive();
        }

        public static void TaskArrayPositive()
        {
            // Задать массив из N положительных чисел и найти в нём сумму двузначных элементов.
            int[] element = new int[10];
            Random random = new Random();

            int length = element.Length;
            int index = 0;
            int sum = 0;

            while (index < length)
            {
                int current = random.Next(30);
                element[index] = current;
                Console.WriteLine(element[index]);

                if (current >= 10 && current <= 99)
                {
                    sum = sum + current;
                }
                index++;
            }

            Console.WriteLine(sum);
        }
    }
}
