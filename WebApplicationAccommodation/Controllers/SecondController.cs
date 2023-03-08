using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAccommodation.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
