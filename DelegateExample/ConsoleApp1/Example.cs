using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void MyDelegate(string message);
    delegate void MultiDelegate();
    delegate void PrintMessage(string msg);
    delegate void MessageHandler();
    delegate int Operation(int a, int b);
    delegate double CalcDelegate(double x, double y);
    public delegate void NoParameters();
    public delegate float WithParameters(int x, bool y);
    public delegate string StringParameters(string str1, string str2);
    public delegate T AddDelegate<T>(T x, T y);
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

        static void MetodAllPrint()
        {

            Console.WriteLine();

            // Метод принмающий Predicate
            List<int> FilterNumbers(List<int> numbers, Predicate<int> filter)
            {
                return numbers.FindAll(filter);
            }

            // Метод принимающий Func
            List<int> TransformNumber(List<int> number, Func<int, int> transform)
            {
                return number.Select(transform).ToList();
            }

            // Метод принимающий Action
            void ProcessNumbers(List<int> numbers, Action<int> process)
            {
                foreach (var item in numbers)
                {
                    process(item);
                }
            }

            // Использование
            List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Фильтрация
            var filtered = FilterNumbers(num, x => x > 5);
            Console.WriteLine("Числа больше 5: " + string.Join(", ", filtered));

            // Преобразование
            var transformed = TransformNumber(num, x => x * x);
            Console.WriteLine("Квадраты чисел: " + string.Join(", ", transformed));

            // Обработка
            ProcessNumbers(num, x => Console.WriteLine($"Число: {x}"));
        }

        static void DelrgateMain()
        {
            Console.WriteLine();

            void Hello(string name) => Console.WriteLine($"Привет, {name}");
            void Bye(string name) => Console.WriteLine($"Пока, {name}");

            MyDelegate del = Hello;
            del += Bye;

            del("Маша");
        }

        static void Method1() => Console.WriteLine("Method 1");
        static void Method2() => Console.WriteLine("Method 2");
        static void SayHello(string name) => Console.WriteLine($"Hello, {name}!");
        static void Great() => Console.WriteLine("Привет");
        static void ShowDate() => Console.WriteLine(DateTime.Now.ToShortDateString());
        static void Bye() => Console.WriteLine("Пока");
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
        public static int Add(int x, int y) => x + y;
        public static int Multiply(int x, int y) => x * y;
        public static int Sqrt(int a, int b) => a * a + b * b;
        public static void ExamplePrint(Operation operation) => Console.WriteLine("Вывод: " + operation(2, 2));
        public static void ExampleGeneric()
        {
            Example example = new Example();
            AddDelegate<int> delInt = example.AddInt;
            Console.WriteLine($"\nThe sum of integers: {delInt(8, 6)}");

            AddDelegate<double> deldouble = example.AddDouble;
            Console.WriteLine($"The sum of real numers: {deldouble(45.67, 62.81)}");

            AddDelegate<char> delChar = Example.AddChar;
            Console.WriteLine($"The sum characters: {delChar('S', 'h')}");
            Console.WriteLine($"The sum characters: {delChar('S', 'y')}");
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
        static void TextRead()
        {
            string filePath = "Log.txt";
            string context = DateTime.Now.ToShortDateString();
            File.WriteAllText(filePath, context);

            Console.WriteLine("Файл создан");
        }
        public static void SwitchDelegate()
        {
            Console.WriteLine("Введите число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Operation operation = null;
            switch (c)
            {
                case 1:
                    operation = Example.Add;
                    break;
                case 2:
                    operation = Example.Multiply;
                    break;
                case 3:
                    operation = Example.Sqrt;
                    break;
                default:
                    Console.WriteLine("Не правильное число");
                    break;
            }

            Example.ExamplePrint(operation);
        }
        static void GetInvocationLists()
        {
            Console.WriteLine("\nGetInvocationLists: ");

            Calculator calc = new Calculator();
            CalcDelegate delAll = calc.Add;
            delAll += Calculator.Sub;
            delAll += calc.Mult;
            delAll += calc.Div;

            foreach (CalcDelegate i in delAll.GetInvocationList())
            {
                // массив делегатов
                try
                {
                    Console.WriteLine($"Result: {i(5.7, 3.2)}");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void PredicatePrint()
        {
            // Пример 1 : Простой Predicate
            Predicate<int> isEven = x => x % 2 == 0;
            Console.WriteLine(isEven(4)); // true
            Console.WriteLine(isEven(5)); // false

            // Пример 2 : Использование Predicate в методе
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Фильтрация чётных чисел
            // FindAll(isEven) — это функция, которая ищет все элементы, для которых функция isEven возвращает true.
            List<int> evwnNumbers = numbers.FindAll(isEven);
            Console.WriteLine(evwnNumbers.Count); // 5
            Console.WriteLine(string.Join(",", evwnNumbers)); // 2, 4, 6, 8, 10

            // Пример 3 : Сложный Predicate
            Predicate<string> isValidPassword = password =>
                password.Length >= 8 && //  пароль должен быть не короче 8 символов
                password.Any(char.IsUpper) && // в пароле должна быть хотя бы одна заглавная буква
                password.Any(char.IsLower) && // в пароле должна быть хотя бы одна маленькая буква
                password.Any(char.IsDigit) && //  в пароле должна быть хотя бы одна цифра
                password.Any(ch => !char.IsLetterOrDigit(ch)); // это условие проверяет, есть ли в пароле хотя бы один символ

            Console.WriteLine(isValidPassword("Pass123")); // False
            Console.WriteLine(isValidPassword("Password#123")); // True
        }
        static void ActionPrint()
        {
            Console.WriteLine("\n");

            // Пример 1 : Использование Action для выполненя метода без параметров
            Action greet = () => Console.WriteLine("Привет мир!");
            greet.Invoke();

            // Пример 2 : Action с параметрами
            Action<string, int> action = (name, age) => Console.WriteLine($"Имя: {name}, Возвраст: {age}");
            action("Иван", 22);

            // Пример 3 : Использование Action в методе
            void ProcessData(Action<int, int> operation, int a, int b)
            {
                Console.WriteLine("Ночало обработки");
                operation(a, b);
                Console.WriteLine("Конец обработки");
            }

            ProcessData((x, y) => Console.WriteLine($"{x + y}"), 5, 3);
        }
        static void FuncPrint()
        {
            // Пример 1 : Простой Func
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(add(3, 5)); // 8

            // Пример 2 : Func с разными типами параметров
            Func<string, string, int> getLengthSum = (s1, s2) => s1.Length + s2.Length;
            Console.WriteLine(getLengthSum("Hello", "World")); // 10

            // Пример 3 : Использование Func в LINQ
            List<int> num = new List<int>() { 1, 2, 3, 4, 5 };

            // Использование Func в методe Select
            var squares = num.Select(x => x * x).ToList();
            Console.WriteLine(string.Join(", ", squares)); // 1, 4, 9, 16, 25

            // Пример 4 : Сложный Func
            Func<int, int, string> calculateAndFormat = (a, b) =>
            {
                int sum = a + b;
                int product = a * b;
                return $"Сумма : {sum}, Произведение: {product}"; // возвращает строку, где подставлены полученные значения
            };

            Console.WriteLine(calculateAndFormat(3, 4)); // Сумма : 7, Произведение: 12

        }
        public static void ShowMessage()
        {
            Console.WriteLine("Have fun!");
        }
        public static string StringMessage(string str1, string str2)
        {
            return $"{str1}, {str2} Have fun!";
        }
    }
}
