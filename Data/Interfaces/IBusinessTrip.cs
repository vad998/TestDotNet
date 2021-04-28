using System.Collections.Generic;
using TestDotNet.Data.Models;

namespace TestDotNet.Data.Interfaces
{
    public interface IBusinessTrip
    {
        IEnumerable<BusinessTrip> GetBusinessTrips { get; }
        BusinessTrip GetBusinessTripById(int businessTripId);
        void SaveBusinessTrip(BusinessTrip businessTrip);
        void DeleteBusinessTrip(int id);
    }
}