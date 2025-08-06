using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        delegate void Message();
        delegate void MessageHandler();
        delegate void Loger();
        delegate int Operation(int a, int b);
        delegate void MyDelegate(string message);
        delegate void PrintMessage(string msg);
        delegate void MultiDelegate();
        delegate int MathOperation(int a, int b);

        // .NET предоставляет готовые делегаты для удобства:
        Action<string> act = s => Console.WriteLine(s);
        Func<int, int> square = x => x * x;
        Predicate<int> isEven = x => x % 2 == 0;
        static void SayHello(string name) => Console.WriteLine($"Hello, {name}!");
        static void Method1() => Console.WriteLine("Method 1");
        static void Method2() => Console.WriteLine("Method 2");
        static int Add(int x, int y) => x + y;
        static int Multiply(int x, int y) => x * y;
        static int Sqrt(int a, int b) => a * a + b * b;
        static void Example(Operation operation) => Console.WriteLine("Вывод: " + operation(2,2));
        static void Great() => Console.WriteLine("Привет");
        static void ShowDate() => Console.WriteLine(DateTime.Now.ToShortDateString());
        static void Bye() => Console.WriteLine("Пока");
        static void Main(string[] args)
        {
            // // Присваиваем этой переменной адрес метода
            Message message1 = Welcome.Print;
            Message message2 = new Hello().Display;

            // Лямбда
            MathOperation op = (a, b) => a + b;  // Лямбда для сложения
            Console.WriteLine(op(1, 2)); // 3

            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            numbers.ForEach(n => Console.Write(n + " "));  // Выводит каждый элемент

            // Делегаты с параметрами и возвращаемым значением
            MathOperation operationMath = Add;
            Console.WriteLine(operationMath(3, 4));  // 7
            operationMath = Multiply;
            Console.WriteLine(operationMath(3, 4)); // 12

            // Вызываем метод
            message1(); 
            message2();

            MultiDelegates();
            LogerPrint();

            Console.ReadKey();
            Console.Clear();
            SwitchDelegate();
            
        }

        static void SwitchDelegate()
        {
            Console.WriteLine("Введите число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Operation operation = null;
            switch (c)
            {
                case 1:
                    operation = Add;
                    break;
                case 2:
                    operation = Multiply;
                    break;
                case 3:
                    operation = Sqrt;
                    break;
                default:
                    Console.WriteLine("Не правильное число");
                    break;
            }

            Example(operation);
        }

        static void MultiDelegates()
        {
            MultiDelegate multi = Method1;
            multi += Method2; // Добавляем второй метод

            // Создание экземпляра делегата
            PrintMessage msg = SayHello;

            // Вызов через делегат
            msg("World");  // Вывод: Hello, World!
            multi(); // Вывод: Method 1 и Method 2
            multi -= Method1; // // Удаляем первый
            multi(); // Выводим Metod 2

            MessageHandler messageHandler = Great;
            messageHandler += ShowDate;
            messageHandler += Bye;
            messageHandler();
        }

        static void TextRead()
        {
            string filePath = "Log.txt";
            string context = DateTime.Now.ToShortDateString();
            File.WriteAllText(filePath, context);

            Console.WriteLine("Файл создан");
        }

        static void LogerPrint()
        {
            Console.WriteLine("\n");

            MessageHandler messageHandler = Great;
            messageHandler += ShowDate;
            messageHandler += Bye;

            messageHandler();

            MessageHandler loger = TextRead;
            loger += Great;
            loger += ShowDate;
            loger += Bye;

            loger += messageHandler;

            loger();

            
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
