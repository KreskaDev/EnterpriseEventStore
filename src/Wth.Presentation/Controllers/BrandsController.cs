using Microsoft.AspNetCore.Mvc;

namespace Wth.Presentation.Controllers
{
    public class BrandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
