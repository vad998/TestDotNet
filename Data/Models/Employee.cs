using System.Collections.Generic;

namespace TestDotNet.Data.Models
{
    public class Employee
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public int positionId { get; set; }
        public virtual Position Position { get; set; }
        public List<BusinessTrip> businessTrips { get; set; }
    }
}