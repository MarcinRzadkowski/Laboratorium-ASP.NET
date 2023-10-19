using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result(Models.Calculator  model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
    }
}
