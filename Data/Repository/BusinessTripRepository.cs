using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestDotNet.Data.Interfaces;
using TestDotNet.Data.Models;

namespace TestDotNet.Data.Repository
{
    public class BusinessTripRepository : IBusinessTrip
    {
        private readonly AppDBContext appDBContext;

        public BusinessTripRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<BusinessTrip> GetBusinessTrips => appDBContext.BusinessTrip.Include(b => b.Employee).Include(e => e.Employee.Position);

        public BusinessTrip GetBusinessTripById(int businessTripId) => appDBContext.BusinessTrip.FirstOrDefault(b => b.id == businessTripId);

        public void SaveBusinessTrip(BusinessTrip businessTrip)
        {
            if (businessTrip.id == default)
            {
                appDBContext.BusinessTrip.Add(businessTrip);
            }
            else
            {
                appDBContext.BusinessTrip.Update(businessTrip);
            }

            appDBContext.SaveChanges();
        }

        public void DeleteBusinessTrip(int id)
        {
            var businessTrip = GetBusinessTripById(id);
            appDBContext.BusinessTrip.Remove(businessTrip);
            appDBContext.SaveChanges();
        }
    }
}