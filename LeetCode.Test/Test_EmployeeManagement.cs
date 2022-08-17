using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    public class Test_EmployeeManagement
    {
        private List<Employee> employees;


        [SetUp]
        public void Setup()
        {
            employees = new List<Employee>
                {
                    new Employee {Name = "Tom", Age = 32,Department = "Design",Salary=120000},
                    new Employee {Name = "John", Age = 22,Department = "UI",Salary=86000},
                    new Employee {Name = "Sandra", Age = 36,Department = "UI",Salary=83000},
                    new Employee {Name = "Julie", Age = 54,Department = "Javascript",Salary=80000},
                    new Employee {Name = "Samantha", Age = 21,Department = "Design",Salary=125000}
                };

        }

        [Test]
        public void T01_Test_AverageAgeForEachCompany()
        {
            //Arrange
            EmployeeManagement employeeManagement = new EmployeeManagement();

            //Act
            var actualResult = employeeManagement.AverageAgeForEachCompany(employees);

            //Assert
            //Assert.That(actualResult, Is.EqualTo(1));
        }

        [Test]
        public void T02_Test_CountOfEmployeesForEachCompany()
        {
            //Arrange
            EmployeeManagement employeeManagement = new EmployeeManagement();

            //Act
            var actualResult = employeeManagement.CountOfEmployeesForEachCompany(employees);

            //Assert
            //Assert.That(actualResult, Is.EqualTo(1));
        }

        [Test]
        public void T02_Test_OldestAgeForEachCompany()
        {
            //Arrange
            EmployeeManagement employeeManagement = new EmployeeManagement();

            //Act
            var actualResult = employeeManagement.OldestAgeForEachCompany(employees);

            //Assert
            //Assert.That(actualResult, Is.EqualTo(1));
        }
    }
}
