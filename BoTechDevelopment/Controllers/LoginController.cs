using BoTechDevelopment.Models.LoginSystem.Backend;
using BoTechDevelopment.Models.LoginSystem.Frontend;
using Microsoft.AspNetCore.Mvc;

namespace BoTechDevelopment.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult RegisterSubmit(RegisterViewModel model)
        {

            return VerifyEmail(new User());
        }
        public IActionResult VerifyEmail(User user)
        {
            return View(user);
        }
        public IActionResult VerifyEmailSubmit(User user)
        {
            return RedirectToAction("Index", "Login");
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }

    }
}
