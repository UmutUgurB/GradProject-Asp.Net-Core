
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeFit.Controllers
{
    public class EventController : Controller
    {
        ActivitiyUserManager aum = new ActivitiyUserManager(new EfActivityUserRepository());
        ActivityServiceManager activityServiceManager = new ActivityServiceManager(new EfActivityRepository());
        UserManager _userManager = new UserManager(new EfUserRepository());

        Context c = new Context();  
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.eventUserID = c.Users.Where(x => x.UserEmail == usermail).Select(y => y.UserID).FirstOrDefault();
            var activities = activityServiceManager.GetList();
            return View(activities);  
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Activity activity)
        {
            var usermail = User.Identity.Name;
            var userID = c.Users.Where(x=> x.UserEmail == usermail).Select(y=> y.UserID).FirstOrDefault();


           
            activity.FounderID = userID;

            
            
            activityServiceManager.Add(activity);
                
            
            return View(activity);
        }
        [HttpGet]
        public IActionResult Join(int activityId, int userId)
        {

            try
            {
                var activityUser = aum.CreateActivityUser(activityId, userId);
                aum.JoinActivity(activityUser);

                TempData["SuccessMessage"] = "Kaydınız başarıyla alındı";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Kaydınız alınamadı: Bu etkinliğe zaten Kayıtlısınız! " ;
            }

            return RedirectToAction("Index");
        }
        public IActionResult MyEventList()
        {
            var usermail = User.Identity.Name;
            var userID = c.Users.Where(x=> x.UserEmail == usermail).Select(y=>y.UserID).FirstOrDefault();
            var values = activityServiceManager.GetActivitiesByUser(userID);
            return View(values);
        }
        public IActionResult Participants(int activityId)
        {
            var activity = activityServiceManager.GetParticipantsById(activityId);  
            if (activity == null)
            {
                return NotFound();
            }

            if (activity.ActivityUsers == null)
            {
                activity.ActivityUsers = new List<ActivityUser>();
            }

            var participants = activity.ActivityUsers.Select(au => au.User).ToList();
            ViewBag.ParticipantCount = participants.Count ;

            return View(participants);
        }
        [HttpPost]
        public IActionResult Delete(int activityId)
        {
            // Kurucu kimliğini oturumdan veya başka bir kaynaktan alın
            int founderId = GetCurrentUserId();

            activityServiceManager.DeleteByFounder(activityId, founderId);
            return RedirectToAction("Index");
        }

        private int GetCurrentUserId()
        {
            var usermail = User.Identity.Name;
            var userID = c.Users.Where(x => x.UserEmail == usermail).Select(y => y.UserID).FirstOrDefault();
            return userID; // Bu sadece bir örnek, oturum yönetimi ile ilgili gerçek uygulamanızda bu değeri almanız gerekecek.
        }
    }
}
