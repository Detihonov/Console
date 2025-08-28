using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public class Department
    {
        public int Id { get; set; }
        public string ShortName { get; set; } = "";
        public string? LongName { get; set; }

        public void Print()
        {
            Console.WriteLine($"Id: {this.Id}");
            Console.WriteLine($"Short Name: {this.ShortName}");
            Console.WriteLine($"Long Name: {this.LongName}");
            Console.WriteLine();
        }
    }
}
