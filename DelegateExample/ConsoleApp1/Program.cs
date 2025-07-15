using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // delegate ВозвращаемыйТип ИмяДелегата(Параметры);
        delegate void Message(); // Объявляем делегат
        delegate void MyDelegate(string message);  // Делегат для метода, принимающего string и ничего не возвращающего
        delegate void PrintMessage(string msg);
        delegate void MultiDelegate();
        delegate int MathOperation(int a, int b);

        // .NET предоставляет готовые делегаты для удобства:
        // Action<T>: Не возвращает значение(void). Пример: Action<string> act = s => Console.WriteLine(s);
        // Func<T, TResult>: Возвращает значение.Пример: Func<int, int> square = x => x * x;
        // Predicate<T>: Возвращает bool (для фильтров). Пример: Predicate<int> isEven = x => x % 2 == 0;
        static void Main(string[] args)
        {
            // // Присваиваем этой переменной адрес метода
            Message message1 = Welcome.Print;
            Message message2 = new Hello().Display;

            MultiDelegate multi = Method1;
            multi += Method2; // Добавляем второй метод

            // Создание экземпляра делегата
            PrintMessage msg = SayHello;

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
            message1(); // Welcome
            message2(); // Привет

            // Вызов через делегат
            msg("World");  // Вывод: Hello, World!
            multi(); // Вывод: Method 1 и Method 2
            multi -= Method1; // // Удаляем первый
            multi(); // Выводим Metod 2
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void Method1() { Console.WriteLine("Method 1"); }
        static void Method2() { Console.WriteLine("Method 2"); }
        static int Add(int x, int y) { return x + y; }
        static int Multiply(int x, int y) { return x * y; }
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
