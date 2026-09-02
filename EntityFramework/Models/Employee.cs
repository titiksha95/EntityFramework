namespace EntityFramework.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string? Name { get; set; }

        public string? Gender { get; set; }

        public string? City { get; set; }

        public int DepartmentId { get; set; }

        public Department? Department { get; set; }
    }
}