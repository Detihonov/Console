using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQlink
{
    public class Example
    {
        public void PrintWhere()
        {
            var list = new List<string>()
            {
                "Первое",
                "Второе",
                "Третье",
                "Четвёртое",
                "Пятое"
            };

            var list1 = list.Where(x => x.Contains("П")).Distinct();
            var print = string.Join(Environment.NewLine, list1);
            Console.WriteLine(print);

            var select = list.Select(x => x);
            Console.WriteLine("\n" + string.Join(Environment.NewLine,select));
        }

        private void Print()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(CountEvenLinq(numbers));

            Console.WriteLine();

            List<int> numLinq = GetEvenNumbersLINQ(numbers);

            foreach (var item in numLinq)
            {
                Console.WriteLine(item);
            }
        }

        public List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenNumbers.Add(item);
                }
            }

            return evenNumbers;
        }

        public List<int> GetEvenNumbersLINQ(List<int> numbers)
        {
            List<int> evenNumbers = numbers.Where(item => item % 2 == 0).ToList();
            return evenNumbers;
        }

        public int Sum(List<int> numbers)
        {
            int sum = 0;

            foreach (var item in numbers)
            {
                sum += item;
            }

            return sum;
        }

        public int SumLinq(List<int> number) => number.Sum();

        static int Min(List<int> num)
        {
            int min = num[0];

            foreach (var item in num)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public int MinLinq(List<int> number) => number.Min();

        public int CountEven(List<int> num)
        {
            int count = 0;

            foreach (var item in num)
            {
                if (item % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        static int CountEvenLinq(List<int> numbers) => numbers.Count(item => item % 2 == 0);
    }
}
