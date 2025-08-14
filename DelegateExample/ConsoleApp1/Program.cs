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
        // delegate | Объявляет тип делегата — шаблон метода
        // Создание | MyDelegate del = MethodName;
        // Вызов	| del(value); или del.Invoke(value);
        // +=       | Добавляет метод в делегат
        // -=       | Удаляет метод из делегата

        delegate void Message();
        delegate void Loger();
        delegate int MathOperation(int a, int b);

        // .NET предоставляет готовые делегаты для удобства:
        Action<string> act = s => Console.WriteLine(s);
        Func<int, int> square = x => x * x;
        Predicate<int> isEven = x => x % 2 == 0;

        static void Main(string[] args)
        {
            // // Присваиваем этой переменной адрес метода
            Message message1 = Welcome.Print;
            Message message2 = new Hello().Display;

            // Лямбда
            MathOperation op = (a, b) => a + b;
            Console.WriteLine(op(1, 2)); // 3

            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            numbers.ForEach(n => Console.Write(n + " "));  // Выводит каждый элемент

            // Делегаты с параметрами и возвращаемым значением
            MathOperation operationMath = Example.Add;
            Console.WriteLine(operationMath(3, 4));  // 7
            operationMath = Example.Multiply;
            Console.WriteLine(operationMath(3, 4)); // 12

            NoParameters npPrm = new(Example.ShowMessage);
            StringParameters strParm = new(Example.StringMessage);
            
            string value = strParm("Boris", "Ivan");
            Console.WriteLine(value);

            npPrm += delegate () { Console.WriteLine("Have fun!"); };

            // Вызываем метод
            message1(); 
            message2();

            Temperature.TemperaturePrint();
            Example.ExampleGeneric();
            Student.StudentListForEach();
            Student.StudentList();
            npPrm();

            // Monitor Bank
            StockMonitor st = new StockMonitor();
            st.PriceChangeHandler = st.ShowPrice;
            st.Start();

            Console.ReadKey();
            Console.Clear();
            Example.SwitchDelegate();
        }


    }
}
