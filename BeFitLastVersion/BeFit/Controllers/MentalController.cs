using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class MentalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
