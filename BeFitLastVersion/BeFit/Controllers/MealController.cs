using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class MealController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
