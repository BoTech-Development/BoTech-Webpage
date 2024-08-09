using BoTechDevelopment.API_Models.Software;
using BoTechDevelopment.Models.ThreeD_Library;
using BoTechDevelopment.ViewModels.ThreeD_Library;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol.Core.Types;
using Version = BoTechDevelopment.API_Models.Software.Update.Version;

namespace BoTechDevelopment.Controllers;

public class ThreeDLibraryController : Controller
{
    SearchResults SearchResults2 = new SearchResults
        {
            Posts =
            [
                new Post
                {
                    Title = "Water Pump",
                    Content = "# Water Pump\n - Just three parts are needed.\n - Gardena compatible!",
                    CardTitle = "Water Pump",
                    ImageSources = ["/pup/Uploads/3D_Library/Water Pump/ISim.png"],
                    ThreeDFiles = [
                        new ThreeDItem
                        {
                            Files = [
                                "/pup/Uploads/3D_Library/Water_Pump/v1.0.1.Release/Bottom v3.f3d", 
                                "/pup/Uploads/3D_Library/Water_Pump/v1.0.1.Release/Bottom v3.step", 
                                "/pup/Uploads/3D_Library/Water_Pump/v1.0.1.Release/Rotor v3.f3d", 
                                "/pup/Uploads/3D_Library/Water_Pump/v1.0.1.Release/Rotor v2.step", 
                                "/pup/Uploads/3D_Library/Water_Pump/v1.0.1.Release/Bottom v2.f3d", 
                                "/pup/Uploads/3D_Library/Water_Pump/v1.0.1.Release/Top v2.step"],
                            Version = new Version
                            {
                                Major = 1,
                                Minor = 0,
                                Patch = 1,
                                SecondPatch = -1,
                                UpdateRevision = EUpdateRevision.Release
                            }
                        }
                    ]
                },
                new Post
                {
                    Title = "BoTech1",
                    Content = "# Water Pump\n - Just three parts are needed.\n - Gardena compatible!",
                    CardTitle = "Water Pump1",
                },
                new Post
                {
                    Title = "Water Pump2",
                    Content = "# Water Pump\n - Just three parts are needed.\n - Gardena compatible!",
                    CardTitle = "Water Pump2",
                },
                new Post
                {
                    Title = "Water Pump3",
                    Content = "# Water Pump\n - Just three parts are needed.\n - Gardena compatible!",
                    CardTitle = "Water Pump3",
                },
                new Post
                {
                    Title = "Water Pump4",
                    Content = "# Water Pump\n - Just three parts are needed.\n - Gardena compatible!",
                    CardTitle = "Water Pump4",
                },
                new Post
                {
                    Title = "Water Pump5",
                    Content = "# Water Pump\n - Just three parts are needed.\n - Gardena compatible!",
                    CardTitle = "Water Pump5",
                },
                new Post
                {
                    Title = "Water Pump6",
                    Content = "# Water Pump\n - Just three parts are needed.\n - Gardena compatible!",
                    CardTitle = "Water Pump6",
                },
                new Post
                {
                    Title = "Water Pump7",
                    Content = "# Water Pump\n - Just three parts are needed.\n - Gardena compatible!",
                    CardTitle = "Water Pump7",
                },
                new Post
                {
                    Title = "Water Pump8",
                    Content = "# Water Pump\n - Just three parts are needed.\n - Gardena compatible!"
                },
            ],
        };

    public SearchResults SearchResults = new SearchResults();

    private readonly IWebHostEnvironment _webHostEnvironment;

    public ThreeDLibraryController(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;

        string path = _webHostEnvironment.WebRootPath.Replace("wwwroot", "");
        StreamReader reader = new StreamReader(path + "/pup/Uploads/3D_Library/init.json");
        SearchResults = JsonConvert.DeserializeObject<SearchResults>(reader.ReadToEnd());
    }
    public IActionResult Index()
    {
        return View(SearchResults);
    }
    [Route("3D_library/Index/{page}")]
    public IActionResult Index(int page)
    {
        if(page > 0)
        SearchResults.Page = page;
        return View(SearchResults);
    }

    public IActionResult Search(string searchText)
    {
        SearchResults result = new SearchResults();
        foreach (Post item in SearchResults.Posts)
        {
            if (item.CardTitle.Contains(searchText) || item.CardText.Contains(searchText) ||
                item.Title.Contains(searchText) || item.Content.Contains(searchText))
            {
                result.Posts.Add(item);
            }
        }
        result.SearchText = searchText;
        return View("Index", result);
    }

    public IActionResult ViewPost(string PostName)
    {
        ViewPostViewModel model = new ViewPostViewModel();
        if ((model.Post = SearchResults.Posts.Where(post => post.Title.Equals(PostName)).FirstOrDefault()) != null)
        {
            return View(model);
        }
        return View("Index", null);
    }
    public IActionResult ViewEdit(string postName, int selectedVersion, int selectedFile)
    {
        ViewPostViewModel model = new ViewPostViewModel
        {
            SelectedVersion = selectedVersion,
            SelectedFile = selectedFile
        };
        if ((model.Post = SearchResults.Posts.Where(post => post.Title.Equals(postName)).FirstOrDefault()) != null)
        {
            return View("ViewPost", model);
        }
        return View("Index", null);
    }

    public IActionResult Download(string postName, int selectedVersion, int selectedFile)
    {
        ViewPostViewModel model = new ViewPostViewModel
        {
            SelectedVersion = selectedVersion,
            SelectedFile = selectedFile
        };
        if ((model.Post = SearchResults.Posts.Where(post => post.Title.Equals(postName)).FirstOrDefault()) != null)
        {
            string path = _webHostEnvironment.WebRootPath;
            path = path + model.Post.ThreeDFiles[selectedVersion].Files[selectedFile];
            
           /* byte[] fileRaw = System.IO.File.ReadAllBytes(path);
            FileResult fileResult = File(fileRaw, System.Net.Mime.MediaTypeNames.Text.Plain, path.Substring(path.LastIndexOf("/"), path.Length - path.LastIndexOf("/")));
            ViewBag.FileResult = fileResult;
            */
           //DownloadFile(path);
           
            //return View("ViewPost", model);
            return RedirectToAction("DownloadFile", "Download", new
            {
                redirectUrl = "",
                filePath = model.Post.ThreeDFiles[selectedVersion].Files[selectedFile]
            });
        }
        return View("Index", null);
    }

    public IActionResult DownloadFile(string path)
    {
        byte[] fileRaw = System.IO.File.ReadAllBytes(path);
        FileResult fileResult = File(fileRaw, System.Net.Mime.MediaTypeNames.Text.Plain, path.Substring(path.LastIndexOf("/"), path.Length - path.LastIndexOf("/")));
        return File(fileRaw, System.Net.Mime.MediaTypeNames.Text.Plain);
    }
}