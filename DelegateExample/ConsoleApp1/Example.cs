using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Example
    {
        public int AddInt(int x, int y) => x + y;
        public double AddDouble(double x, double y) => (double)x + y;
        public static char AddChar(char x, char y) => (char)(x + y);

        public static void DelegateAll()
        {
            // Пример использования всех трёх делегатов вместе
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Predicate для фильтрации
            Predicate<int> isEven = x => x % 2 == 0;

            // Func для преобразования (умножение)
            Func<int, int, int> multy = (x, y) => x * y;

            // Action для вывода результата
            Action<string> print = message => Console.WriteLine(message);

            // Использование
            var evenNumbers = numbers.FindAll(isEven);
            print($"Чётные числа: {string.Join(", ", evenNumbers)}");

            List<int> multypled = evenNumbers.Select(x => multy(x, 2)).ToList();
            print("Умножение на 2: " + string.Join(", ", multypled));
        }
    }
}
