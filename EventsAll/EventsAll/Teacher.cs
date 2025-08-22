using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAll
{
    public class Teacher
    {
        public event ExamDelegate examEvent;

        public void Exam(string task) => examEvent?.Invoke(task);
    }
}
