using Employees.Classes;

namespace Employees.Test
{
    [TestFixture]
    public class Tests
    {
        private EmployeeService _employeeService;

        [SetUp]
        public void Setup()
        {
            _employeeService = new EmployeeService();
        }

        [Test]
        public void GetAll_ReturnsAllEmployees()
        {
            // Act
            var result = _employeeService.GetAll();

            // Assert
            Assert.That(result, Has.Count.EqualTo(5), "The quantity of employees should be 5");
        }

        [Test]
        [TestCase("Pedro")]
        [TestCase("Juan")]
        [TestCase("Andrés")]
        [TestCase("Ana")]
        public void FindByName_ReturnsOneEmployee(string name)
        {
            // Act
            var result = _employeeService.FindByName(name);

            // Assert
            Assert.That(result.Name, Is.EqualTo(name), "The name of the returned employee should match the test case");
        }

        [Test]
        public void FindByName_ReturnsNull_WhenTheEmployeeDoesntExist()
        {
            // Act
            var result = _employeeService.FindByName(null);

            // Assert
            Assert.That(result, Is.EqualTo(null), "The result should be null");
        }

        [Test]
        public void GetByHigherSalary_ReturnsTheEmployeeWithTheHigherSalary()
        {
            // Act
            var result = _employeeService.GetByHigherSalary();

            // Assert

            Assert.Multiple(() =>
            {                
                Assert.That(result.Name, Is.EqualTo("Pedro"), "The name of the employee should be Pedro");
                Assert.That(result.Salary, Is.EqualTo(10000), "The salary of the employee should be 10000");
            });
        }

        [Test]
        public void GetAllOrderedBySalaryDesc_ReturnsAllEmployeesOrderedBySalaryDesc()
        {
            // Act
            var result = _employeeService.GetAllOrderedBySalaryDesc();

            // Assert
            Assert.That(result.Last().Name, Is.EqualTo("Ana"), "The name of the last employee should be Ana");
        }
    }
}