using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Students
    {
        // pulic field
        private int grade = 2;

        public void PrintGrade()
        {
            Console.WriteLine("Grade: " + grade);
        }

        // public metod with ref  return
        public ref int DoWork()
        {
            // return reference of grade field
            return ref grade;
        }

        // params
        public void DisplaySubjects(params string[] str)
        {
            Console.WriteLine("\nDisplay Foreach: ");

            foreach (string str2 in str)
            {
                Console.WriteLine("\t" + str2);
            }

            Console.WriteLine("\nDisplay For: ");

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("\t" + str[i]);
            }
        }

        // Metod DisplayMarks
        public void DisplayMarks(int marks1, int marks2, int marks3)
        {
            double avg = getAverageMarks();

            Console.WriteLine("\nShowing ratings: ");
            Console.WriteLine("\tMarks 1: " + marks1);
            Console.WriteLine("\tMarks 2: " + marks2);
            Console.WriteLine("\tMarks 3: " + marks3);
            Console.WriteLine("\tAverage marks: " + avg);

            // create local function
            double getAverageMarks()
            {
                double average = (double)(marks1 + marks2 + marks3) / 3;
                return average;
            }
        }
    }
}
