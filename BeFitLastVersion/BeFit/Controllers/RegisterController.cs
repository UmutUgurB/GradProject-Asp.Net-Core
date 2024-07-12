using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    
    public class RegisterController : Controller
    {
        

        UserManager um = new UserManager(new EfUserRepository());   


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User p)
        {
            UserValidator vr = new UserValidator();
            ValidationResult results = vr.Validate(p);

            if (results.IsValid)
            {
                p.UserIsActive = true;
                p.DepartmentID = 1;

                um.UserAdd(p);
                TempData["SuccessMessage"] = "Kaydınız başarıyla oluşturuldu";
                return RedirectToAction("Login", "Login");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(p);
        }
    }
}
