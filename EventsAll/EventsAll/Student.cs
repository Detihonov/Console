using System;
using System.Collections.Generic;

namespace EventsAll
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public void Exam(string task)
        {
            Console.WriteLine($"Student {LastName} solved the {task}");
        }
    }
}
