using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueusDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemosQueues();
        }

        static void DemosQueues()
        {
            // Первый вошел и первй вышел
            Queue<string> str = new Queue<string>();
            str.Enqueue("Старт игры");
            str.Enqueue("Встреча с врагом");
            str.Enqueue("Найти артифакт");

            foreach (var item in str) Console.WriteLine(item);

            // Старт игры
            Console.WriteLine();
            string strr = str.Dequeue();

            Console.WriteLine(strr);

            foreach (var item in str) Console.WriteLine(item);

            Console.WriteLine(str.Peek());
        }
    }
}
