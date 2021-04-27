using Microsoft.AspNetCore.Mvc;
using TestDotNet.Data.Interfaces;
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

        public ViewResult Index()
        {
            var businessTrips = new HomeViewModel
            {
                BusinessTrips = _businessTrip.BusinessTrips
            };

            return View(businessTrips);
        }
    }
}