using System.Collections.Generic;
using TestDotNet.Data.Models;

namespace TestDotNet.Data.Interfaces
{
    public interface IBusinessTrip
    {
        IEnumerable<BusinessTrip> BusinessTrips { get; }
        BusinessTrip getBusinessTrip(int businessTripId);
    }
}