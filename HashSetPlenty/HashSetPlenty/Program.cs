using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetPlenty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plenty();
        }

        public static void Plenty()
        {
            // Пример использования HashSet<T>
            HashSet<int> set = new();

            // Добавить элемента (уникальные значения)
            set.Add(1);
            set.Add(2);
            set.Add(6);
            set.Add(3);


            // Удаление элемента
            set.Remove(2);

            // Выводим в консоль
            Console.WriteLine(string.Join(" ", set));

            foreach (var item in set)
            {
                Console.Write(item + " ");
            }

            // Примеры операций c HashSet<T>
            HashSet<int> set1 = new() { 1, 2, 3, 4, 5 };
            HashSet<int> set2 = new() { 4, 5, 6, 7, 8 };

            // Пересечение (Intersection) множеств set и set2
            set1.Intersect(set2);

            Console.WriteLine("\nПересечение множеств set1 и set2: ");

            foreach (var number in set1)
            {
                Console.Write(number + " ");
            }

            // Объединение (Union) множеств:
            set1 = new() { 1, 2, 3, 4, 5 };
            set2 = new() { 4, 5, 6, 7, 8 };

            // set1 теперь содержит все уникальные элементы из обоих множеств
            set1.Union(set2);
            Console.WriteLine("\nОбъединение множеств set1 и set2: ");

            foreach (var number in set1)
            {
                Console.Write(number + " ");
            }

            // Разность (Difference) Множеств
            set1 = new() { 1, 2, 3, 4, 5 };
            set2 = new() { 4, 5, 6, 7, 8 };

            // set1 ткакрь содержит элементы
            // присуствующие в set1 и отсуствующие в set2
            set1.ExceptWith(set2);
            Console.WriteLine("\nРазность множеств set1 и set2: ");

            foreach (var number in set1)
            {
                Console.Write(number + " ");
            }
        }
    }
}
