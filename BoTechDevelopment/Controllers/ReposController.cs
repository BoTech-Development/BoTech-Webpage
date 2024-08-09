using Microsoft.AspNetCore.Mvc;

namespace BoTechDevelopment.Controllers
{
    public class ReposController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CurrentStatus()
        {
            return View();
        }
        public IActionResult VersionHistory()
        {
            return View();
        }
    }
}
