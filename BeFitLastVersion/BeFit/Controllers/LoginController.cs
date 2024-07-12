using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BeFit.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(User p)
        {
            Context c = new Context();
            var user = c.Users.FirstOrDefault(x => x.UserEmail == p.UserEmail);

            if (user == null)
            {
                ModelState.AddModelError("UserEmail", "Bu e-posta adresi ile kayıtlı kullanıcı bulunamadı.");
                return View(p);
            }
            else if (user.UserPassword != p.UserPassword)
            {
                ModelState.AddModelError("UserPassword", "Şifre hatalı.");
                return View(p);
            }
            else
            {
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, p.UserEmail)
        };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);

                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "LandingPage");
            }
        }

    }
}
