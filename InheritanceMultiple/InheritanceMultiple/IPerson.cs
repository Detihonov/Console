using System;

namespace InheritanceMultiple
{
    interface IPerson
    {
        DateTime DateOfBirth { get; set; }

        int GetAge();
    }
}
