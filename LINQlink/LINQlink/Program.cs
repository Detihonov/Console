using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQlink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7};
            Console.WriteLine(CountEvenLinq(numbers));

            Console.WriteLine();

            List<int> numLinq = GetEvenNumbersLINQ(numbers);

            foreach (var item in numLinq)
            {
                Console.WriteLine(item);
            }
        }

        static List<int> GetEvenNumbers(List<int> numbers)
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

        static List<int> GetEvenNumbersLINQ(List<int> numbers)
        {
            List<int> evenNumbers = numbers.Where(item => item % 2 == 0).ToList();
            return evenNumbers;
        }

        static int Sum(List<int> numbers)
        {
            int sum = 0;

            foreach (var item in numbers)
            {
                sum += item;
            }

            return sum;
        }

        static int SumLinq(List<int> number) => number.Sum();

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

        static int MinLinq (List<int> number) => number.Min();

        static int CountEven(List<int> num)
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
