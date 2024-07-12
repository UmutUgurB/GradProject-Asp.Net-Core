using BeFit.Models;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace BeFit.Controllers
{
    public class ExercisePlanController : Controller
    {
        ExercisePlanManager _exercisePlanManager = new (new EfExercisePlanRepository());
        DayManager _dayManager = new(new EfDayRepository());
        WeekManager _weekManager = new(new EfWeekRepository());
        UserManager _userManager = new UserManager(new EfUserRepository());
        UserExercisePlanManager _userExercisePlanManager = new(new EfUserExercisePlanRepository());

        Context c = new Context();
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.UserID = c.Users.Where(x => x.UserEmail == usermail).Select(y => y.UserID).FirstOrDefault();
            var values = _exercisePlanManager.GetList();
            return View(values);
        }

        public IActionResult Soldier(Week week)
        {
            var values = _weekManager.GetList().Where(e=>e.WeekCategories==1).ToList();
            return View(values);
        }
        public IActionResult Gladiator(Week week)
        {
            var values = _weekManager.GetList().Where(e => e.WeekCategories == 2).ToList();
            return View(values);
        }
        public IActionResult ChampionWay(Week week)
        {
            var values = _weekManager.GetList().Where(e => e.WeekCategories == 3).ToList();
            return View(values);
        }
        public IActionResult Warrior(Week week)
        {
            var values = _weekManager.GetList().Where(e => e.WeekCategories == 4).ToList();
            return View(values);
        }
        public IActionResult Mamba(Week week)
        {
            var values = _weekManager.GetList().Where(e => e.WeekCategories == 5).ToList();
            return View(values);
        }
        public IActionResult Champion(Week week)
        {
            var values = _weekManager.GetList().Where(e => e.WeekCategories == 6).ToList();
            return View(values);
        }

        public IActionResult Details(int id)
        {
            var values = _dayManager.GetDayById(id).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Join(int exerciseProgramId, int userId)
        {
            try
            {
                var exercisePlanUser = _userExercisePlanManager.CreateExercisePlanUser(exerciseProgramId, userId);
                _userExercisePlanManager.JoinExercisePlan(exercisePlanUser);

                TempData["SuccessMessage"] = "Kaydınız başarıyla alındı";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Kaydınız alınamadı: Bu programa zaten Kayıtlısınız! ";
            }

            return RedirectToAction("Index");
        }
        public IActionResult UserExercisePrograms(int userId)
        {
            var usermail = User.Identity.Name;
            var userID = c.Users.Where(x => x.UserEmail == usermail).Select(y => y.UserID).FirstOrDefault();
            var exercisePrograms = _exercisePlanManager.GetExerciseProgramsByUserId(userID);
            return View(exercisePrograms);
        }
        public IActionResult WeekDetails(int exerciseProgramId)
        {
            var values = _weekManager.GetListWeeksByExercisePlan(exerciseProgramId).ToList();
            return View(values);
        }
    }
}
