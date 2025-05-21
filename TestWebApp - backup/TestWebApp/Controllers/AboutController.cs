using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.Controllers
{
    public class AboutController : Controller
    {
        // /about - default method
        public IActionResult Index()
        {
            return View();
        }
    }
}
