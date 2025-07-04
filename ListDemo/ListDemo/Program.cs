using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    internal class Program
    {
        static List<int> numbers = new List<int>() { 1, 2, 3, 4, 5};
        static List<object> str = new List<object> { 1, "a", false};
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", numbers));

            numbers.Capacity = 10;
            Console.WriteLine(string.Join("Количество элементов: ","", numbers.Capacity));

            numbers.Add(6);
            Console.WriteLine(string.Join(" ", numbers));

            List<int> ints = new List<int> { 7, 8, 9};
            numbers.AddRange(ints);
            Console.WriteLine(string.Join(" ", numbers));

            numbers.Sort();
            Console.WriteLine(string.Join("Index of element 5 is: ", "", + numbers.BinarySearch(5)));

            //numbers.Clear();
            Console.WriteLine(string.Join("Contains is 3: ", "", numbers.Contains(3)));
            Console.WriteLine(string.Join("Contains is 20: ", "", numbers.Contains(20)));

            numbers.Insert(0, 9);
            Console.Write("Insert is 0 to 9: ");
            Console.WriteLine(string.Join(" ", numbers));

            List<int> subList = new List<int>() { 0, 1, 2, 3};
            numbers.InsertRange(1, subList);
            numbers.Sort();
            Console.Write("Sort: ");
            Console.WriteLine(string.Join(" ", numbers));

            numbers.Remove(1);
            Console.Write("Remove: ");
            Console.WriteLine(string.Join(" ", numbers));

            numbers.RemoveAt(12);
            Console.Write("RemoveAt: ");
            Console.WriteLine(string.Join(" ", numbers));

            numbers.RemoveRange(0, 3);
            Console.Write("RemoveRange: ");
            Console.WriteLine(string.Join(" ", numbers));

            numbers.Capacity = 20;
            Console.WriteLine("Capacity before trim: " + numbers.Capacity);
            numbers.TrimExcess();
            Console.WriteLine("Capacity after trim: " + numbers.Capacity);

            Console.Write("Все элементы < 10: ");
            bool areNumbers = numbers.TrueForAll(x => x < 10);
            Console.WriteLine(areNumbers);

            Console.Write("Reverse: ");
            numbers.Reverse();
            foreach (int number in numbers) Console.Write(number + " ");

            Console.Write("\nForEach: ");
            numbers.Sort();
            numbers.ForEach(PrintToOutputWindow);

            Console.Write("\nIndexOf: ");
            Console.WriteLine(numbers.IndexOf(3)); // 1

            Console.Write("LastIndex: ");
            Console.WriteLine(numbers.LastIndexOf(9)); // 8

            Console.Write("FindLast: ");
            Console.Write(numbers.FindLast(x => x < 3)); // 2

            Console.Write("\nToArray: ");
            int[] arrayTo = numbers.ToArray();
            Console.Write(arrayTo[1]); // 3

            Console.WriteLine("\n");
            ArrayListDemo();
        }

        static void PrintToOutputWindow(int i)
        {
            Console.Write(i + " ");
        }

        static void ArrayListDemo()
        {
            string[] items = { "Меч", "Щит", "Копьё"};

            foreach (string item in items) Console.WriteLine(item);

            List<Player> players = new List<Player>()
            {
                new Player("Player1", 100, 5),
                new Player("Player2", 80, 4),
                new Player("Player3", 60, 3)
            };

            players.Add(new Player("Player4", 40, 2));
        }


    }

    class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        public Player(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }
    }
}
