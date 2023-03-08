using Microsoft.AspNetCore.Mvc;
using WebApplicationAccommodation.Models;

namespace WebApplicationAccommodation.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            PriceViewModel priceView = new PriceViewModel() { Name = "Sif" };
            return View(priceView);
        }

        public IActionResult Create()
        {
            var priceVm = new PriceViewModel();
            return View(priceVm);
        }

        public IActionResult CreatePrice(PriceViewModel price)
        {
            return View("Index");
        }
    }
}
