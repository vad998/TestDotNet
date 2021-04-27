using System.Collections.Generic;
using System.Linq;
using TestDotNet.Data.Interfaces;
using TestDotNet.Data.Models;

namespace TestDotNet.Data.Mocks
{
    public class MockEmployee : IEmployee
    {
        private readonly IPosition _positionEmployees = new MockPosition();

        public IEnumerable<Employee> Employees
        {
            get
            {
                return new List<Employee>
                {
                    new Employee
                    {
                        firstName = "Даниил",
                        lastName = "Соловьёв",
                        middleName = "Эльдарович",
                        Position = _positionEmployees.Positions.First()
                    },
                    new Employee
                    {
                        firstName = "Вадим",
                        lastName = "Зыков",
                        middleName = "Русланович",
                        Position = _positionEmployees.Positions.Last()
                    }
                };
            }
        }

        public Employee getEmployee(int employeeId)
        {
            throw new System.NotImplementedException();
        }
    }
}