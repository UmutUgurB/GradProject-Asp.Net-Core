using BeFit.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;

namespace BeFit.Controllers
{
    public class PlaceController : Controller
    {
        PlaceManager _placeManager = new PlaceManager(new EfPlaceRepository());
        CommentManager _commentManager = new CommentManager(new EfCommentRepository());
        Context c = new Context();  
        public IActionResult Index()
        {
            var values = _placeManager.GetList();
            
            return View(values);
        }
        public IActionResult CommentListByPlace(int placeId)
        {
            
            ViewBag.ort = c.PlaceRatings.Where(x => x.PlaceID == placeId).Select(x => x.PlaceOrtalama).ToList(); 
            var values = _commentManager.GetCommentByPlace(placeId);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }
        [HttpPost]  
        public IActionResult AddComment(AddCommentImage c, int placeId)
        {
            Comment x = new Comment();  
            if(c.CommentImage != null)
            {
                var extension = Path.GetExtension(c.CommentImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CommentImageFolder/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                c.CommentImage.CopyTo(stream);
                x.CommentImage = newimagename;
            }
            x.CommentTitle = c.CommentTitle;
            x.CommentUserName = c.CommentUserName;  
            x.CommentContent = c.CommentContent;    
            x.CommentDate = c.CommentDate;
            x.PlaceScore = c.PlaceScore;
            x.PlaceID = placeId;


            _commentManager.Add(x);
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public IActionResult AddPlace() 
        { 
            return View();  
        }
        [HttpPost]
        public IActionResult AddPlace(AddPlaceImage p)
        {
            Place x = new Place();
            if(p.PlaceImage != null)
            {
                var extension = Path.GetExtension(p.PlaceImage.FileName);    
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/PlaceImageFolder/",newimagename);
                var stream = new FileStream(location,FileMode.Create);
                p.PlaceImage.CopyTo(stream);
                x.PlaceImage = newimagename;
            }
            x.PlaceName = p.PlaceName;
            x.PlaceDescription = p.PlaceDescription;
            x.TicketIsAvailable = p.TicketIsAvailable;  

            _placeManager.Add(x);
            return RedirectToAction("Index","Place");
        }
        public IActionResult Details(int id)
        {
            var values = _placeManager.GetDetailById(id);
            return View(values);
        }
    }
}
