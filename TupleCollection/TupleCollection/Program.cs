using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuples();
        }

        public static void Tuples()
        {
            /*
             Tuple в C# — это неизменяемый (immutable) контейнер для хранения набора значений разных (или одинаковых) типов без создания отдельного класса или структуры. 
             Начиная с C# 7, появились «языковые» кортежи (…), но само понятие «tuple» присутствует в библиотеке System и через System.ValueTuple.
             */

            // Использование кортежей
            (int one, int two) pair = (1, 2);
            Console.Write(pair.one + " ");
            Console.Write(pair.two + "\n");
            Console.WriteLine();

            (int x, int y, string name, int[] values) pair2 = (1, 2, "str", new[] { 1, 2, 3 });
            Console.WriteLine("Именованный кортеж: ");
            Console.WriteLine(pair2.x);
            Console.WriteLine(pair2.y);
            Console.WriteLine(pair2.name);
            foreach (var item in pair2.values)
            {
                Console.Write(item); 
            }

            Console.WriteLine("\n");
            var myTuple = (1, "hello", true);
            Console.WriteLine($"Кортеж - число: { myTuple.Item1}, строка: { myTuple.Item2}, булево: {myTuple.Item3}");

            // Деконструкция кортежа
            var (number, word, flag) = myTuple;
            Console.WriteLine($"Деконструкция - число: {number}, строка: {word}, булево: {flag}");

            // Использование именованных кортежей
            var namedTuple = (Count: 1, Greeting: "hello", Flag: true);
            Console.WriteLine($"Именованный кортеж - Count: {namedTuple.Count}, Greeting: {namedTuple.Greeting}, Flag: {namedTuple.Flag}");
        }
    }
}
