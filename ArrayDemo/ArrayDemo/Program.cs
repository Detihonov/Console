using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            string[] str = new string[3];
            string[] str2 = new string[3] { "a", "b", "c" };
            string[] str3 ={ "1", "2", "3", "0" };
            int [] num = new int[] { 1, 2, 3, 4, 5};

            Console.WriteLine("Первый элемент массива: " + str2[0]); // 2
            Console.WriteLine("Длина массива: " + str3.Length); // 4

            // Сортировка
            Array.Sort(str3);
            Console.Write("Сортировка массива: ");

            foreach (var item in str3)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            // Max & Min & Length
            var max = num.Max();
            var min = num.Min();    
            var lrngth = num.Length;

            Console.WriteLine("Максимальное значение: " + max);
            Console.WriteLine("Минимальное значение: " + min);
            Console.WriteLine("Количество элементов в массиве: " + lrngth);

            // 2D Array
            int[,] matrix = new int[3, 3];
            int[,] matrixInt =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 5, 6, 7 },
                { 6, 7, 8 }
            };

            Console.WriteLine("2D Array: " + matrixInt[1, 2]); // 6
            

            // Jagged
            int[][] arJagged = new int[3][];
            arJagged[0] = new int[] {1, 2, 3 };
            arJagged[1] = new int[] {4, 5, 6};
            arJagged[2] = new int[] {5, 6, 7};

            Console.Write("Jagged: ");

            foreach (int[] arr in arJagged)
            {
                Console.WriteLine();
                foreach (int nums in arr)
                {
                    Console.Write(nums + " ");
                }
            }

            // Reverse
            int[] numbers = new int [6]{1, 2, 3, 3, 4, 5 };
            Array.Reverse(numbers);
            Console.Write("\nReverse: " + string.Join(", ", numbers));

            // Clear
            Array.Clear(numbers, 0, 5);
            Console.Write("\nClear: " + string.Join(", ", numbers));

            // Copy
            int[] numbers2 = { 1, 2, 3, 4, 5 };
            int[] numbers3 = new int [numbers2.Length];

            Array.Copy(numbers2,numbers3,numbers2.Length);
            Console.Write("\nCopy: " + string.Join(", ", numbers3));


        }
    }
}
