namespace TCPData
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }

        public void Print()
        {
            Console.WriteLine($"Id: {this.Id}");
            Console.WriteLine($"First Name: {this.FirstName}");
            Console.WriteLine($"Last Name: {this.LastName}");
            Console.WriteLine($"Annual Salary: {this.AnnualSalary}");
            Console.WriteLine($"Manager: {this.IsManager}");
            Console.WriteLine();
        }
    }
    
}
