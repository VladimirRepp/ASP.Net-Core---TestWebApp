using Microsoft.AspNetCore.Mvc;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    public class ContactsController : Controller
    {
        // /contacts - default method
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] // указываем атрибут с методом работы с данными 
        public IActionResult Chect(Contact contact)
        {
            if (!ModelState.IsValid)
                return Redirect("/error");

            // do some
            return View("Index");
        }
    }
}
