using Microsoft.AspNetCore.Mvc;
using TestDotNet.Data.Interfaces;
using TestDotNet.Data.Models;
using TestDotNet.ViewModels;

namespace TestDotNet.Controllers
{
    public class HomeController : Controller
    {
        private IBusinessTrip _businessTrip;

        public HomeController(IBusinessTrip businessTrip)
        {
            _businessTrip = businessTrip;
        }

        public IActionResult BusinessTripEdit(int id)
        {
            BusinessTrip businessTrip = id == default ? new BusinessTrip() : _businessTrip.GetBusinessTripById(id);
            return View(businessTrip);
        }

        [HttpPost]
        public IActionResult BusinessTripEdit(BusinessTrip businessTrip)
        {
            if (ModelState.IsValid)
            {
                _businessTrip.SaveBusinessTrip(businessTrip);
                return RedirectToAction("Index");
            }

            return View(businessTrip);
        }

        [HttpPost]
        public IActionResult BusinessTripDelete(int id)
        {
            _businessTrip.DeleteBusinessTrip(new BusinessTrip { id = id });
            return RedirectToAction("Index");
        }

        public ViewResult Index()
        {
            var businessTrips = new HomeViewModel
            {
                BusinessTrips = _businessTrip.GetBusinessTrips
            };

            return View(businessTrips);
        }
    }
}