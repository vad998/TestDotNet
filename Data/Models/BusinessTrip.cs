using System;

namespace TestDotNet.Data.Models
{
    public class BusinessTrip
    {
        public int id { get; set; }
        public string city { get; set; }
        public DateTime departureDate { get; set; }
        public DateTime arrivalDate  { get; set; }
        public int employeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}