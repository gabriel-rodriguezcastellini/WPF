using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees.Classes
{
    public class EmployeeService
    {
        private static readonly string[] _letters = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        
        public Dictionary<string, List<Employee>> GetHigherSalaries()
        {
            var classA = new ClassA();
            var response = new Dictionary<string, List<Employee>>();

            foreach (var letter in _letters)
            {
                if (classA.Employees.Any(x => Encoding.UTF8.GetString(Encoding.GetEncoding("ISO-8859-8").GetBytes(x.Surname.ToUpper())).Contains(letter)))
                {
                    response.Add(letter, classA.Employees.Where(x => x.Salary == classA.Employees.Where(x => x.Surname.ToUpper().Contains(letter)).Max(x => x.Salary) && Encoding.UTF8.GetString(Encoding.GetEncoding("ISO-8859-8").GetBytes(x.Surname.ToUpper())).Contains(letter)).ToList());
                }
            }

            return response;
        }

        public List<Employee> GetAll()
        {
            return new ClassA().Employees.ToList();
        }

        public Employee FindByName(string name)
        {
            return new ClassA().Employees.FirstOrDefault(x => x.Name == name);
        }

        public Employee GetByHigherSalary()
        {
            return new ClassA().Employees.OrderByDescending(x=>x.Salary).First();
        }

        public List<Employee> GetAllOrderedBySalaryDesc()
        {
            return new ClassA().Employees.OrderByDescending(x => x.Salary).ToList();
        }
    }
}
