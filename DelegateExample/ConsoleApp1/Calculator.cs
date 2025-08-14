using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public double Add(double x, double y) => x + y;
        public static double Sub(double x, double y) => x - y;
        public double Mult(double x, double y) => x * y;
        public double Div(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            throw new DivideByZeroException();
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
    }
}
