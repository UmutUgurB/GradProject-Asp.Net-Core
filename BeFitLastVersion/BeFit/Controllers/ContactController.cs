using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactRepository());  


        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact p)
        {
            try
            {
                // İletişim bilgisini ekleme işlemi
                contactManager.ContactAdd(p);

                // Başarılı mesajı ve yönlendirme
                TempData["SuccessMessage"] = "İşleminiz başarıyla gerçekleştirildi.";
                return RedirectToAction("Contact", "Contact");
            }
            catch (Exception ex)
            {
                // Hata durumunda işlem başarısız mesajı ve yönlendirme
                TempData["ErrorMessage"] = "İşlem başarısız oldu. Hata: " + ex.Message;
                return RedirectToAction("Contact", "Contact");
            }
        }
        public IActionResult MessageList()
        {
            ViewBag.SuccessMessage = TempData["SuccessMessage"];
            ViewBag.ErrorMessage = TempData["ErrorMessage"];
            var values = contactManager.GetList().ToList();
            return View(values);
        }
        [HttpPost]
        public IActionResult DeleteContactMessage(int Id)
        {
            var value = contactManager.GetById(Id);
            if (value != null)
            {
                contactManager.Delete(value);
                TempData["SuccessMessage"] = "Kayıt başarıyla silindi";
            }
            else
            {
                TempData["ErrorMessage"] = "Kayıt bulunamadı";
            }

            return RedirectToAction("MessageList");
        }
    }
}
