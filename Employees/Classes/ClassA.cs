using System.Collections.Generic;

namespace Employees.Classes
{
    public class ClassA
    {
        private readonly List<Employee> _employees;
        public IReadOnlyCollection<Employee> Employees => _employees;

        public ClassA()
        {
            _employees = new()
            {
                new() { Name = "Pedro", Surname = "Alonso Gutiérrez", Salary = 10000 },
                new() { Name = "Juan", Surname = "Aguilar López", Salary = 9000 },
                new() { Name = "Andrés", Surname = "Carrasco Pérez", Salary = 9500 },
                new() { Name = "Ana", Surname = "Costa Villa", Salary = 8500 },
                new() { Name = "Andrés", Surname = "Moreno Nieto", Salary = 9500 }
            };
        }
    }
}
