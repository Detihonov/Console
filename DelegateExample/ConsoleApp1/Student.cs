using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"Surname: {LastName}, Name: {FirstName}, Born: {BirthDate.ToLongDateString()}";
        }

        public static void StudentList()
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

        public static void StudentListForEach()
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

        static void FullNameVoid(Student student)
        {
            Console.WriteLine($"{student.Id}.{student.LastName} {student.FirstName}");
        }

        static string FullNameString(Student student)
        {
            return $"{student.Id}.{student.LastName} {student.FirstName}";
        }

        static bool OnlySpring(Student student)
        {
            return student.BirthDate.Month >= 3 && student.BirthDate.Month <= 5;
        }
    }
}
