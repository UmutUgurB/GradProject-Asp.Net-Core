using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BeFit.Controllers
{
    public class AdminController : Controller
    {
        UserManager _userManager = new UserManager(new EfUserRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            
            ViewBag.v1 = c.Users.Count().ToString();
            ViewBag.v2 = c.ExercisePrograms.Count().ToString();
            ViewBag.v3 = c.Exercises.Count().ToString();
            ViewBag.v4 = c.Activities.Count().ToString();
            ViewBag.v5 = c.UserExercisePrograms.Select(x => x.ExerciseProgramId ==1 ).Count().ToString();
            ViewBag.v6 = c.UserExercisePrograms.Where(x=> x.ExerciseProgramId ==1).Count().ToString();
            ViewBag.v7 = c.UserExercisePrograms.Where(x => x.ExerciseProgramId == 2).Count().ToString();
            ViewBag.v8 = c.UserExercisePrograms.Where(x => x.ExerciseProgramId == 3).Count().ToString();
            ViewBag.v9 = c.UserExercisePrograms.Where(x => x.ExerciseProgramId == 4).Count().ToString();
            ViewBag.v10 = c.UserExercisePrograms.Where(x => x.ExerciseProgramId == 5).Count().ToString();
            ViewBag.v11 = c.UserExercisePrograms.Where(x => x.ExerciseProgramId == 6).Count().ToString();
            ViewBag.v12 = c.Exercises.Where(x=>x.ExerciseCategory == 1).Count().ToString();  
            
            return View();
        }
        
        public IActionResult MemberList()
        {
            ViewBag.SuccessMessage = TempData["SuccessMessage"];
            ViewBag.ErrorMessage = TempData["ErrorMessage"];
            var values = _userManager.GetList();
            return View(values);
        }
        [HttpPost]
        public IActionResult DeleteUser(int userID)
        {
            var value = _userManager.GetById(userID);
            if (value != null)
            {
                _userManager.Delete(value);
                TempData["SuccessMessage"] = "Kayıt başarıyla silindi";
            }
            else
            {
                TempData["ErrorMessage"] = "Kayıt bulunamadı";
            }

            return RedirectToAction("MemberList");
        }
        public IActionResult Best()
        {
            using (var context = new Context())
            {
                // En yüksek PlaceOrtalama değerine sahip PlaceRating kaydını bulma
                var bestPlaceRating = context.PlaceRatings
                                             .OrderByDescending(pr => pr.PlaceOrtalama)
                                             .FirstOrDefault();

                if (bestPlaceRating != null)
                {
                    // PlaceId üzerinden Place kaydını bulma
                    var bestPlace = context.Places
                                           .FirstOrDefault(p => p.PlaceID == bestPlaceRating.PlaceID);

                    if (bestPlace != null)
                    {
                        ViewBag.BestPlaceName = bestPlace.PlaceName;
                        ViewBag.BestPlaceOrtalama = bestPlaceRating.PlaceOrtalama;
                    }
                    else
                    {
                        ViewBag.BestPlaceName = "No place found for the best rating";
                        ViewBag.BestPlaceOrtalama = 0;
                    }
                }
                else
                {
                    ViewBag.BestPlaceName = "No ratings available";
                    ViewBag.BestPlaceOrtalama = 0;
                }
            }

            return View();
        }
        public IActionResult MessageList()
        {

            return View();
        }
    }
}
