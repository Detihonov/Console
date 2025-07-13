using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Program
    {
        // Поток выполнения - наименьшая единица обработки для паралельного выполнения отдельных частей одно программы.
        // Для работы с потоками выполнения в .NET есть пространство именн System.Threading и основной его класс Thread.
        
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(WriteChar));
            ThreadRead(thread);



        }

        private static void ThreadRead(Thread thread)
        {
            Console.WriteLine("Для запуска нажмте любую клавишу");
            Console.ReadKey();

            thread.Start('*');

            for (int i = 0; i < 80; i++)
            {
                Console.Write('-');
                Thread.Sleep(70);
            }
        }

        private static void WriteChar(object arg)
        {
            char item = (char)arg;
            for (int i = 0; i < 80; i++)
            {
                Console.Write(item);
                Thread.Sleep(70);
            }
        }
    }
}
