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
            //TaskArrayPositive();
            DecompositionArrayPositive();
        }

        public static void TaskArrayPositive()
        {
            // Задать массив из N положительных чисел и найти в нём сумму двузначных элементов.
            int[] element = new int[10];
           

            int length = element.Length;
            int index = 0;
            int sum = 0;

            while (index < length)
            {
                Random random = new Random(); 
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

        public static void DecompositionArrayPositive()
        {
            int[] array = CreareArray(count:20);
            Fill(array);
            int sum = GetSumm(array:array);

            Console.WriteLine(Print(collection:array));
            Console.WriteLine($"sum = {sum}");

        }

        public static int[] CreareArray(int count)
        {
            return new int[count];
        }

        public static void Fill(int[] element)
        {
            Random rnd = new Random();
            int length = element.Length;
            int index = 0;

            while (index < length)
            {
                
                int current = rnd.Next(30);
                element[index] = current;
                index = index + 1;
            }
        }

        public static int GetSumm(int[] array)
        {
            int size = array.Length;
            int sum = 0;
            int position = 0;

            while (position < size)
            {
                int current = array[position];
                if (current >= 10 && current <= 99)
                {
                    sum = sum + current;
                }
                position = position +1;
            }
            return sum;
        }

        static string Print(int[] collection)
        {
            string output = string.Empty;

            int size = collection.Length;
            int index = 0;

            while (index < size)
            {
                int current = collection[index];
                output = output + $"{current} ";
                index = index + 1;
            }
            return output;
        }

    }
}
