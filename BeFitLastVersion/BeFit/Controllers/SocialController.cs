using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class SocialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
