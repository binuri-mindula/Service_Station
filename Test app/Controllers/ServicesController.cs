using Microsoft.AspNetCore.Mvc;
using Test_app.Models;


namespace Test_app.Controllers
{
    public class ServicesController : Controller
    {
        [ViewData]
        public string PageTitle { get; set; }    //View data attribute
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            PageTitle = "Service Details";

            var service = new VehicalService
            {
                Id = 1,
                Title = "Oil change",
                Description = "Change the oil in your car",
                Cost = 23.21m
            };

            //ViewData["Service"] = service;    //View data dictionary
            ViewBag.Service = service;

            return View();
        }


    }
}
