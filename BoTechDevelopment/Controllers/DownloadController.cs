using System.Runtime.InteropServices.JavaScript;
using BoTechDevelopment.ViewModels.Download;
using Microsoft.AspNetCore.Mvc;

namespace BoTechDevelopment.Controllers;

public class DownloadController : Controller
{
    // Redirect to Home 
    public IActionResult Index()
    {
        return RedirectToAction("Index", "Home");
    }

    public IActionResult DownloadFile(string redirectUrl, string filePath, bool showTimer = false, int timerDelay = 0)
    {
        return View(new DownloadViewModel(redirectUrl, filePath, showTimer, timerDelay));
    }
}