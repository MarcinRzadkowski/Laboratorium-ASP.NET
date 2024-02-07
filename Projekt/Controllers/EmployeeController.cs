using Microsoft.AspNetCore.Mvc;

namespace Projekt.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
