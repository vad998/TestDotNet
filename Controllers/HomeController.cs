using System;
using Microsoft.AspNetCore.Mvc;
using TestDotNet.Data.Interfaces;
using TestDotNet.Data.Models;
using TestDotNet.ViewModels;

namespace TestDotNet.Controllers
{
    public class HomeController : Controller
    {
        private IBusinessTrip _businessTrip;
        private IEmployee _employee;

        public HomeController(IBusinessTrip businessTrip, IEmployee employee)
        {
            _businessTrip = businessTrip;
            _employee = employee;
        }

        public ViewResult Index()
        {
            var businessTrips = new HomeViewModel
            {
                BusinessTrips = _businessTrip.GetBusinessTrips,
                Employees = _employee.GetEmployees
            };

            return View(businessTrips);
        }

        [Route("Home/EditBusinessTrip/{id}")]
        public IActionResult EditBusinessTrip(string id)
        {
            int _id = Convert.ToInt32(id.Trim(new Char[] { '{', '}' } ));
            var businessTrip = _businessTrip.GetBusinessTripById(_id);
            var model = new HomeViewModel
            {
                Id = businessTrip.id,
                City = businessTrip.city,
                DepartureDate = businessTrip.departureDate,
                ArrivalDate = businessTrip.arrivalDate,
                EmployeeId = businessTrip.employeeId,
                Employees = _employee.GetEmployees
            };

            return View(model);
        }

        [Route("Home/EditBusinessTrip/SaveBusinessTrip")]
        public RedirectToActionResult EditBusinessTrip(BusinessTrip businessTrip)
        {
            _businessTrip.SaveBusinessTrip(businessTrip);
            return RedirectToAction("Index");
        }

        [Route("Home/SaveBusinessTrip")]
        public RedirectToActionResult SaveBusinessTrip(BusinessTrip businessTrip)
        {
            _businessTrip.SaveBusinessTrip(businessTrip);
            return RedirectToAction("Index");
        }

        [Route("Home/DeleteBusinessTrip/{id}")]
        public RedirectToActionResult DeleteBusinessTrip(string id)
        {
            _businessTrip.DeleteBusinessTrip(Convert.ToInt32(id.Trim(new Char[] { '{', '}' } )));
            return RedirectToAction("Index");
        }
    }
}