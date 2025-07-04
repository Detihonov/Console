using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[3];
            string[] str2 = new string[3] { "a", "b", "c" };
            string[] str3 ={ "1", "2", "3", "0" };
            string[] str4; // Переменная "str4" объявлена, но никогда не используется

            Console.WriteLine("Первый элемент массива: " + str2[0]); // 2
            Console.WriteLine("Длина массива: " + str3.Length); // 4

            // Сортировка
            Array.Sort(str3);
            Console.Write("Сортировка массива: ");

            foreach (var item in str3)
            {
                Console.Write(item + " ");
            }


        }
    }
}
