using Microsoft.AspNetCore.Mvc;

namespace BoTechDevelopment.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
