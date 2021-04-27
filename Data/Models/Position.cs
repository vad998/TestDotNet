using System.Collections.Generic;

namespace TestDotNet.Data.Models
{
    public class Position
    {
        public int id { get; set; }
        public string positionName { get; set; }
        public double salary { get; set; }
        public List<Employee> employees { get; set; }
    }
}