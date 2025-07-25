﻿using System;
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
        // Синхроность - выполнение метода в контексте текущего потока.
        // Асинхроность - выполнение методп в контексте вторичного потока.

        // Асинхронное программирование – подход к написанию кода, который позволяет выполнять второстепенные и долго
        // выполняемые задачи, не блокируя основной поток выполнения.

        // Параллельное программирование – физическое выполнение нескольких операций одновременно.
        // Достигается путем аппаратных возможностей вычислительной техники, а именно благодаря наличию нескольких ядер.

        // Thread Pool – это коллекция потоков, которые могут использоваться для выполнения методов в фоновом режиме.

        
        static void Main(string[] args)
        {
            // Thread thread = new Thread(new ParameterizedThreadStart(WriteChar));

            // ThreadRead(thread);
            // PrintReport();
            //PrintPoolWorker();
            //PrintPoolWorkerResult();
            //PrintSyncFactorialCalculate();


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

        private static void PrintSyncFactorialCalculate()
        {
            int number = 13;
            long result = CalculateFactorial(number);
            Console.WriteLine($"Результат - {result}");

            while (true)
            {
                Console.Write("*");
                Thread.Sleep(300);
            }
        }

        static void PrintPoolWorkerResult()
        {
            Console.WriteLine("Для запуска нажмите любую клавишу");
            Console.ReadKey();
            ThreadPoolWorkerResult<int> res = new ThreadPoolWorkerResult<int>(SumNumber); 
            res.Start(1000);

            while (res.Completed == false)
            {
                Console.Write("*");
                Thread.Sleep(35);
            }

            Console.WriteLine();
            Console.WriteLine($"Результат асинхронной операции = {res.Result:N}");
        }

        static void PrintPoolWorker()
        {
            Console.WriteLine("Для запуска намжите любую клавишу");
            Console.ReadKey();

            ThreadPoolWorker threadPoolWorker = new ThreadPoolWorker(new Action<object>(StartWriter));
            threadPoolWorker.Start('*');

            for (int i = 0; i < 40; i++)
            {
                Console.Write('_');
                Thread.Sleep(50);
            }

            Console.WriteLine();
            threadPoolWorker.Wait();

            Console.WriteLine($"\nМетод Main закончил свою работу.");
        }

        private static void PrintReport()
        {
            Console.WriteLine($"ID потока метода Main - {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Для запуска нажмите любую клавишу");
            Console.ReadKey();

            Report();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Example1));
            Report();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Example2));
            Console.ReadKey();
            Report();
        }

        private static void Report()
        {
            ThreadPool.GetMaxThreads(out int maxWorkerThreads, out int maxPortThreads); // Максимальное количество потоков
            ThreadPool.GetAvailableThreads(out int workerThreads, out int portThreads); // Доступно потоков

            Console.WriteLine($"Рабочии потоки {workerThreads} из {maxWorkerThreads}");
            Console.WriteLine($"IO потоки {portThreads} из {maxPortThreads}");
            Console.WriteLine(new string('_', 80));
        }

        private static void Example1(object state)
        {
            Console.WriteLine($"Метод Example1 начал выполнятся в потоке {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(2000);
            Console.WriteLine($"Метод Example1 закончил выполнятся в потоке {Thread.CurrentThread.ManagedThreadId}");
        }

        private static void Example2(object state)
        {
            Console.WriteLine($"Метод Example2 начал выполнятся в потоке {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Метод Example2 закончил выполнятся в потоке {Thread.CurrentThread.ManagedThreadId}");
        }

        private static void StartWriter(object arg)
        {
            char item = (char)arg;

            for (int i = 0; i < 120; i++)
            {
                Console.Write(item);
                Thread.Sleep(50);
            }
        }

        private static int SumNumber(object arg)
        {
            int number = (int)arg;
            int summ = 0;

            for (int i = 0; i < number; i++)
            {
                summ += i;
                Thread.Sleep(1);
            }
            return summ;
        }

        private static long CalculateFactorial(int number)
        {
            Thread.Sleep(500);

            if (number == 1)
            {
                return number;
            }
            else
            {
                return CalculateFactorial(number - 1) * number;
            }
        }

        private static async Task<long> CalculateFactorialAsync(int number)
        {
            Thread.Sleep(500);

            if (number == 1)
            {
                return number;
            }
            else
            {
                return CalculateFactorial(number - 1) * number;
            }
        }
    }
}
