using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stacks stacks = new Stacks();
            stacks.Push(1);
            stacks.Push(2);
            stacks.Push(3);

            Console.WriteLine(stacks.Pop()); // 3
            Console.WriteLine(stacks.Pop()); // 2
            Console.WriteLine(stacks.Pop()); // 1

            TaskStack();
        }

        static void TaskStack()
        {
            Stack<string> TaskString = new Stack<string>();

            // Добавить задачу
            TaskString.Push("Задача от 15.06.2025");
            TaskString.Push("Задача от 16.06.2025");
            TaskString.Push("Задача от 17.06.2025");
            TaskString.Push("Задача от 18.06.2025");

            // Последняя задача
            string taskLast = TaskString.Pop();

            Console.WriteLine("\n" + taskLast);
        }

        static void StackDemo()
        {
            // Последний вошел и первый вышел
            Stack<string> stk = new Stack<string>();

            // Добавить
            stk.Push("a");
            stk.Push("b");

            // Количество элементов
            Console.WriteLine("Количество элеементов: " + stk.Count);
        }

        private static bool IsBalance(string inputString)
        {
            Stack<char> stackOfOpeningBraces = new Stack<char>();
            Stack<char> stackOfClosingBraces = new Stack<char>();

            foreach (char c in inputString)
            {
                if (c == '}' || c == ']' || c == ')')
                {
                    stackOfClosingBraces.Push(c);
                }
            }

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                if (inputString[i] == '{' || inputString[i] == '[' || inputString[i] == ')')
                {
                    stackOfOpeningBraces.Push(inputString[i]);
                }
            }

            if ((stackOfClosingBraces.Count + stackOfOpeningBraces.Count) % 2 != 0)
            {
                return false;
            }

            while (stackOfClosingBraces.Count != 0)
            {
                char currentClosingBrace = stackOfClosingBraces.Pop();
                char currentOpeningBrace = stackOfOpeningBraces.Pop();

                if ((currentClosingBrace == '}' && currentOpeningBrace == '{') || 
                    (currentClosingBrace == ']' && currentOpeningBrace == '[') || 
                    (currentClosingBrace == ')' && currentOpeningBrace == '('))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
            
        }
    }

    public class Stacks
    {
        const int MAX = 1000;
        int top;
        object[] stack = new object[MAX];

        public Stacks()
        {
            top = -1;
        }

        public void Push(object obj)
        {
            if (top < MAX)
            {
                stack[++top] = obj;
            }
        }

        public object Pop()
        {
            if (top >= 0)
            {
                object o = stack[top];
                top--;
                return o;
            }
            else
            {
                return -1; 
            }
        }

        public object Peek()
        {
            return stack[top];
        }
    }
}
