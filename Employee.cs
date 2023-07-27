using System;

namespace ProblemsUsingGenerics
{
    // Example custom class for Employee
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Employee(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public int CompareTo(Employee other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
