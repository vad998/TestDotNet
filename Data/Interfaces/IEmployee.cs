using System.Collections.Generic;
using TestDotNet.Data.Models;

namespace TestDotNet.Data.Interfaces
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetEmployees { get; }
    }
}