using Microsoft.AspNetCore.Mvc;

namespace BoTechDevelopment.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
