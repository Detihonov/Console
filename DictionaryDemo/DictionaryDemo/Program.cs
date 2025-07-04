using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DictionaryDemos();
        }

        static void DictionaryDemos()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Dictionary <string,int> inventary = new Dictionary<string, int>()
            {
                {"Меч", 1 },
                {"Броня", 2},
                {"Монета", 5 }
            };
            Dictionary<string, int> name = new Dictionary<string, int>()
            {
                {"Alice", 32 },
                {"Bob", 18 }
            };

            int count = inventary.Keys.Count; // 3
            int money = inventary["Монета"]; // 5

            inventary["Меч"] += 1; // + 1 Меч

            inventary.Add("Топор", 5);

            foreach (var key in inventary)
            {
                Console.Write(key.Key + ": "); // Ключ
                Console.WriteLine(" " + key.Value); // Значение
            }

            Console.WriteLine();
            Console.WriteLine(inventary["Меч"]); // 2
            Console.WriteLine();

            // Добавить
            dict.Add("key1", "value1");
            dict.Add("key2", "value2");
            dict.Add("key3", "value3");
            Console.WriteLine("Количество: " + dict.Count); // 1

            // Ключ
            Console.Write("Все ключи в словаре: ");
            Console.WriteLine(string.Join(" ",dict.Keys));

            // Значение
            Console.Write("Все значения в словаре: ");
            Console.WriteLine(string.Join(" ", dict.Values));

            // Удалить
            dict.Remove("key1");

            // Проверить ключ
            if (!dict.ContainsKey("key1"))
            {
                dict.Add("key1", "value1");
            }

            Console.Write("После проверки: ");
            foreach (var key in dict)
            {
                Console.Write(key.Key + " " + key.Value + " | ");
                
            }

            Console.WriteLine();
            Console.WriteLine("Поиск знвчения через []: " + dict["key3"]);

            // получаем значение
            string value = "";
            dict.TryGetValue("key1", out value);

            // очистить словарь
            dict.Clear();

            // Добавление новой пары ключ-значение
            name["Charlie"] = 28;

            Console.WriteLine();
            foreach (var n in name)
            {
                Console.WriteLine($"Имя: {n.Key}, Возвраст: {n.Value}");
            }

            // Перебрать ключи
            Console.WriteLine();
            foreach (var n in name.Keys)
            {
                Console.WriteLine("Ключи: " + n);
            }

            // Перебрать значение
            Console.WriteLine();
            foreach (var n in name.Values)
            {
                Console.WriteLine("Значение: " + n);
            }
        }
    }
}
