using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class SportProgram : Controller
    {
        public IActionResult KTSTest()
        {
            return View();
        }
        public IActionResult BMICalculator()
        {
            return View();
        }
    }
}
