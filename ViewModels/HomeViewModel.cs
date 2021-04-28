using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TestDotNet.Data.Models;

namespace TestDotNet.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<BusinessTrip> BusinessTrips { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        public string City { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int EmployeeId { get; set; }
    }
}