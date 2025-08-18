using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Person() { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Print()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Иван", 25),
                new Person("Denis", 16),
                new Person("Мария", 35),
                new Person("Маша", 38),
                new Person("Алексей", 22),
                new Person("Ольга", 28)
            };

            // Использование Func в Where
            var adults = people.Where(p => p.Age >= 18).ToList();

            Console.WriteLine();

            // Использование Action для вывода
            Action<Person> printPerson = p => { Console.WriteLine($"{p.Name} {p.Age} лет"); };
            adults.ForEach( printPerson );
            Console.WriteLine();

            // Использование Predicate в FindAll
            Predicate<Person> isAdilt = p => p.Age >= 18;
            var filter = people.FindAll(isAdilt);

            // Использование Func в Select
            var names = people.Select(p => p.Name).ToList();
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

        }
    }
}
