using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Single Inheritance : Одиночное наследование
    // Multi-level inheritance : Многоуровневое наследование
    // Hierarchical Inheritance : Иерархическое наследование
    // Multiple Inheritance : Множественное наследование
    // Hybrid Inheritance : гибридное наследование
    public class Person{}
    class Tailor : Person { }
    interface Teacher { }
    class Teacher2 : Person { }
    class Professor : Teacher2 { }
    interface Physician { }
    class Physician2 : Person { }
    class MedicalTeacher : Teacher, Physician { }
}
