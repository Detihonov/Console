using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        delegate void Message(); // Объявляем делегат
        static void Main(string[] args)
        {
            // // Присваиваем этой переменной адрес метода
            Message message1 = Welcome.Print;
            Message message2 = new Hello().Display;

            // Вызываем метод
            message1(); // Welcome
            message2(); // Привет
        }
    }

    class Hello
    {
        public void Display() => Console.WriteLine("Привет");
    }
    class Welcome
    {
        public static void Print() => Console.WriteLine("Welcome");
    }
}
