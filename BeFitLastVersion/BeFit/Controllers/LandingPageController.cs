using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class LandingPageController : Controller
    {

        [Authorize]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.Email = usermail;

            Context c = new Context();
            var userName = c.Users.Where(x=> x.UserEmail == usermail).Select(y=>y.UserName).FirstOrDefault();
            ViewBag.v2 = userName;  
            return View();
        }
    }
}
