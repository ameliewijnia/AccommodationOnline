using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAccommodation.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
