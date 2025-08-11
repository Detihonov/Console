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
        delegate void MessageHandler();
        delegate void Loger();
        delegate int Operation(int a, int b);
        delegate void MyDelegate(string message);
        delegate void PrintMessage(string msg);
        delegate void MultiDelegate();
        delegate int MathOperation(int a, int b);
        delegate double CalcDelegate(double x, double y);
        delegate T AddDelegate<T>(T x, T y);

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
        static void ExamplePrint(Operation operation) => Console.WriteLine("Вывод: " + operation(2,2));
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

            Temperature();
            ExampleGeneric();
            StudentListForEach();
            StudentList();


            Console.ReadKey();
            Console.Clear();
            SwitchDelegate();
            
        }

        static bool OnlySpring(Student student)
        {
            return student.BirthDate.Month >= 3 && student.BirthDate.Month <= 5;
        }

        static void FullNameVoid(Student student)
        {
            Console.WriteLine($"{student.Id}.{student.LastName} {student.FirstName}");
        }

        static string FullNameString(Student student)
        {
            return $"{student.Id}.{student.LastName} {student.FirstName}";
        }

        static void StudentList()
        {

            Console.WriteLine();

            List<Student> group = new List<Student>() {
                new Student
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Miller",
                    BirthDate = new DateTime(1997,3,12)
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Candice",
                    LastName = "Leman",
                    BirthDate = new DateTime(1998,7,22)
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Joey",
                    LastName = "Finch",
                    BirthDate = new DateTime(1996,11,30)
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Nicole",
                    LastName = "Taylor",
                    BirthDate=new DateTime(1996,5,10)
                }
            };

            Console.WriteLine("Born in the spring: ");
            List<Student> students = group.FindAll(OnlySpring);
            foreach (Student i in students)
            {
                Console.WriteLine(i);
            }
        }
        static void StudentListForEach()
        {
            List<Student> group = new List<Student>() {
                new Student
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Miller",
                    BirthDate = new DateTime(1997,3,12)
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Candice",
                    LastName = "Leman",
                    BirthDate = new DateTime(1998,7,22)
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Joey",
                    LastName = "Finch",
                    BirthDate = new DateTime(1996,11,30)
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Nicole",
                    LastName = "Taylor",
                    BirthDate=new DateTime(1996,5,10)
                }
            };

            Console.WriteLine("\nList of students: ");
            group.ForEach(FullNameVoid);

            Console.WriteLine("\nList of students: ");
            IEnumerable<string> students = group.Select(FullNameString);
            foreach (string i in students)
            {
                Console.WriteLine(i);
            }
        }

        static void ExampleGeneric()
        {
            Example example = new Example();
            AddDelegate<int> delInt = example.AddInt;
            Console.WriteLine($"\nThe sum of integers: {delInt(8,6)}");

            AddDelegate<double> deldouble = example.AddDouble;
            Console.WriteLine($"The sum of real numers: {deldouble(45.67, 62.81)}");

            AddDelegate<char> delChar = Example.AddChar;
            Console.WriteLine($"The sum characters: {delChar('S', 'h')}");
            Console.WriteLine($"The sum characters: {delChar('S', 'y')}");
        }

        static void Temperature()
        {
            Console.WriteLine("\nTemperature °C: ");

            // использование
            var monitor = new TemperatureMonitor();

            // подписка на событие Action
            monitor.TemperatureWarning += message => Console.WriteLine(message);

            // подписка на событие Func
            monitor.TemperatureFormater += temp => $"{temp}°C";

            // проверка температуры
            monitor.CheckTemperature(25);
            monitor.CheckTemperature(35);
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

        static void CalculatorDel()
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Ebter an expression: ");
            string expression = Console.ReadLine();
            char sign = ' ';

            // определение знака фрифметического действия
            foreach (char c in expression)
            {
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    sign = c;
                    break;
                }
            }

            try
            {
                // Получение значений операндов
                string[] num = expression.Split(sign);
                CalcDelegate del = null;
                switch (sign)
                {
                    case '+':
                        del = new CalcDelegate(calc.Add);
                        break;
                    case '-':
                        del = new CalcDelegate(Calculator.Sub);
                        break;
                    case '*':
                        del = calc.Mult; // груповое преобразование методов
                        break;
                    case '/':
                        del = calc.Div;
                        break;
                    default:
                        throw new InvalidOperationException();

                }
                Console.WriteLine($"Result: {del(double.Parse(num[0]), double.Parse(num[1]))}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
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

            ExamplePrint(operation);
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

            ProcessData((x,y) => Console.WriteLine($"{x + y}"),5,3);
        }

        static void FuncPrint()
        {
            // Пример 1 : Простой Func
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(add(3, 5)); // 8

            // Пример 2 : Func с разными типами параметров
            Func<string,string,int> getLengthSum = (s1,s2) => s1.Length + s2.Length;
            Console.WriteLine(getLengthSum("Hello", "World")); // 10

            // Пример 3 : Использование Func в LINQ
            List<int> num = new List<int>() { 1, 2, 3, 4, 5};

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

        static void DelegateAll()
        {
            // Пример использования всех трёх делегатов вместе
            List<int> numbers = new List<int>() { 1,2, 3, 4, 5, 6, 7, 8, 9, 10};

            // Predicate для фильтрации
            Predicate<int> isEven = x => x % 2 == 0;

            // Func для преобразования (умножение)
            Func<int, int, int> multy = (x, y) => x * y;

            // Action для вывода результата
            Action<string> print = message => Console.WriteLine(message);

            // Использование
            var evenNumbers = numbers.FindAll(isEven);
            print($"Чётные числа: {string.Join(", ",evenNumbers)}");

            List<int> multypled = evenNumbers.Select(x => multy(x, 2)).ToList();
            print("Умножение на 2: " + string.Join(", ",multypled));
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
            List<int> TransformNumber(List<int> number, Func<int,int> transform)
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
            List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // Фильтрация
            var filtered = FilterNumbers(num, x => x > 5);
            Console.WriteLine("Числа больше 5: " + string.Join(", ", filtered));

            // Преобразование
            var transformed = TransformNumber(num, x => x * x);
            Console.WriteLine("Квадраты чисел: " + string.Join(", ", transformed));

            // Обработка
            ProcessNumbers(num, x => Console.WriteLine($"Число: {x}"));
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

        static void DelrgateMain()
        {
            Console.WriteLine();

            void Hello(string name) => Console.WriteLine($"Привет, {name}");
            void Bye(string name) => Console.WriteLine($"Пока, {name}");

            MyDelegate del = Hello;
            del += Bye;

            del("Маша");
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
