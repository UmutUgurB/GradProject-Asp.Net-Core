using BeFit.Models;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class QuizController : Controller
    {
       public IActionResult TakeAProgram()
        {
            return View();  
        }
    }
}
