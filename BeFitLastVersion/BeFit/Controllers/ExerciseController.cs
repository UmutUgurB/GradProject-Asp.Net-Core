
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class ExerciseController : Controller
    {
        
        ExerciseManager _exerciseManager = new (new EfExerciseRepository());
        public IActionResult ExerciseList(Exercise exercise)
        {
            var values = _exerciseManager.GetList().Where(e => e.ExerciseCategory == 1).ToList();
            return View(values);
        }
        public IActionResult ExerciseCategories(Exercise exercise)
        {
            return View();
        }
        public IActionResult LowerBodyExerciseList(Exercise exercise)
        {
            var values = _exerciseManager.GetList().Where(e => e.ExerciseCategory == 2).ToList();
            return View(values);
        }
        public IActionResult SixPackExerciseList(Exercise exercise)
        {
            var values = _exerciseManager.GetList().Where(e => e.ExerciseCategory == 3).ToList();
            return View(values);
        }
        public IActionResult BurnCaloryExerciseList(Exercise exercise)
        {
            var values = _exerciseManager.GetList().Where(e => e.ExerciseCategory== 4).ToList();
            return View(values);
        }
        public IActionResult ProtectYourselfExerciseList(Exercise exercise)
        {
            var values = _exerciseManager.GetList().Where(e => e.ExerciseCategory == 5).ToList();
            return View(values);
        }
        public IActionResult MyExerciseProgram()
        {
            return View();
        }
        public IActionResult AllExercises()
        {
            ViewBag.SuccessMessage = TempData["SuccessMessage"];
            ViewBag.ErrorMessage = TempData["ErrorMessage"];
            var values = _exerciseManager.GetList().ToList();   
            return View(values);
        }
        [HttpPost]
        public IActionResult DeleteExercise(int Id)
        {
            var value = _exerciseManager.GetById(Id);
            if (value != null)
            {
                _exerciseManager.Delete(value);
                TempData["SuccessMessage"] = "Kayıt başarıyla silindi";
            }
            else
            {
                TempData["ErrorMessage"] = "Kayıt bulunamadı";
            }

            return RedirectToAction("AllExercises");
        }
    }

}

       
