using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TestDotNet.Data.Interfaces;
using TestDotNet.Data.Models;

namespace TestDotNet.Data.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly AppDBContext appDBContext;

        public EmployeeRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Employee> GetEmployees => appDBContext.Employee.Include(e => e.Position);
    }
}