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
    }
}
