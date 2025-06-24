using Microsoft.AspNetCore.Mvc;
using Test_app.Models;


namespace Test_app.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            var service = new VehicalService();
            service.Id = 1;
            service.Title = "Oil change";
            service.Description = "Change the oil in your vehicle";
            service.Cost = 32.23m;
            service.IsDeleted = false;

            return View(service);
        }
    }
}
