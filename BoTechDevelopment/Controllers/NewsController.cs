using Microsoft.AspNetCore.Mvc;

namespace BoTechDevelopment.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
