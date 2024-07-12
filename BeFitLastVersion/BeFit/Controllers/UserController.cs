using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace BeFit.Controllers
{
    public class UserController : Controller
    {
        

        UserManager _userManager = new UserManager(new EfUserRepository());

        Context c = new Context();
        public IActionResult Index()
        {
            
            return View();  

            

        }
        public IActionResult UserProfile()
        {
            return View();
        }
        public IActionResult UserMail()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UserSettings()
        {
            var usermail = User.Identity.Name;
            var userID = c.Users.Where(x => x.UserEmail == usermail).Select(y => y.UserID).FirstOrDefault();



            var userValues = _userManager.GetById(userID);


            return View(userValues);
        }

        [HttpPost]
        public IActionResult UserSettings(User p)
        {
            UserValidator validationRules = new UserValidator();
            ValidationResult results = validationRules.Validate(p);
            var userValues = _userManager.GetById(5);

            if (results.IsValid)
            {
                userValues.UserName = p.UserName;
                userValues.UserEmail = p.UserEmail;
                userValues.UserPhone = p.UserPhone; 
                userValues.UserPassword = p.UserPassword;   
                userValues.UserHeight = p.UserHeight;   
                userValues.UserWeight = p.UserWeight;   

                _userManager.Update(userValues);
                return RedirectToAction("UserSettings","User");
            }
            else
            {
                foreach(var item in results.Errors) 
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View("UserSettings", userValues);
        }

        public IActionResult Test()
        {
            return View();
        }
        


    }
}
