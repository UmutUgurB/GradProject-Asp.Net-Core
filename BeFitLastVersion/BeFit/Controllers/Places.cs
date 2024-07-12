using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class Places : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
