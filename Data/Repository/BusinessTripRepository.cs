using System;
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

        public int SaveBusinessTrip(BusinessTrip businessTrip)
        {
            if (businessTrip.id == default)
            {
                appDBContext.Entry(businessTrip).State = EntityState.Added;
            }
            else
            {
                appDBContext.Entry(businessTrip).State = EntityState.Modified;
            }

            appDBContext.SaveChanges();

            return businessTrip.id;
        }

        public void DeleteBusinessTrip(BusinessTrip businessTrip)
        {
            appDBContext.Entry(businessTrip).State = EntityState.Deleted;
            appDBContext.SaveChanges();
        }
    }
}