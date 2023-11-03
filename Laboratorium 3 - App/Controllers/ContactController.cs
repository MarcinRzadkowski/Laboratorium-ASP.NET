using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3___App.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
