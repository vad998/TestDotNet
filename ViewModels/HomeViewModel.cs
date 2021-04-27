using System.Collections.Generic;
using TestDotNet.Data.Models;

namespace TestDotNet.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<BusinessTrip> BusinessTrips { get; set; }
    }
}