using System;
using System.Collections.Generic;
using System.Linq;
using TestDotNet.Data.Interfaces;
using TestDotNet.Data.Models;

namespace TestDotNet.Data.Mocks
{
    public class MockBusinessTrip : IBusinessTrip
    {
        private readonly IEmployee _employeesBusinessTrip = new MockEmployee();

        public IEnumerable<BusinessTrip> BusinessTrips
        {
            get
            {
                return new List<BusinessTrip>
                {
                    new BusinessTrip
                    {
                        city = "Москва",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(12, 0, 0, 0)),
                        Employee = _employeesBusinessTrip.Employees.First()
                    },
                    new BusinessTrip
                    {
                        city = "Казань",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(18, 0, 0, 0)),
                        Employee = _employeesBusinessTrip.Employees.First()
                    },
                    new BusinessTrip
                    {
                        city = "Екатеринбург",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(14, 0, 0, 0)),
                        Employee = _employeesBusinessTrip.Employees.Last()
                    },
                    new BusinessTrip
                    {
                        city = "Новосибирск",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(63, 0, 0, 0)),
                        Employee = _employeesBusinessTrip.Employees.First()
                    },
                    new BusinessTrip
                    {
                        city = "Анапа",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(25, 0, 0, 0)),
                        Employee = _employeesBusinessTrip.Employees.Last()
                    },
                    new BusinessTrip
                    {
                        city = "Уфа",
                        departureDate = DateTime.Today,
                        arrivalDate = DateTime.Today.Add(new TimeSpan(2, 0, 0, 0)),
                        Employee = _employeesBusinessTrip.Employees.Last()
                    }
                };
            }
        }

        public BusinessTrip getBusinessTrip(int businessTripId)
        {
            throw new System.NotImplementedException();
        }
    }
}