using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
