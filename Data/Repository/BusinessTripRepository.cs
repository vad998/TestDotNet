using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestDotNet.Data.Interfaces;

namespace TestDotNet.Data.Repository
{
    public class BusinessTripRepository : IBusinessTrip
    {
        private readonly AppDBContext appDBContext;

        public BusinessTripRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Models.BusinessTrip> BusinessTrips => appDBContext.BusinessTrip.Include(b => b.Employee);

        public Models.BusinessTrip getBusinessTrip(int businessTripId) => appDBContext.BusinessTrip.FirstOrDefault(b => b.id == businessTripId);
    }
}