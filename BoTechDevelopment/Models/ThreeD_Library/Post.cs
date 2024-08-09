using Microsoft.AspNetCore.Mvc.Rendering;

namespace BoTechDevelopment.Models.ThreeD_Library;

public class Post
{
    public string MainImageSource { get; set; } = String.Empty;
    public List<string> ImageSources { get; set; } = new List<string>();
    public List<ThreeDItem> ThreeDFiles { get; set; } = new List<ThreeDItem>();
    public string Content { get; set; } = "# Hellord"; // Markdown
    public string Title { get; set; } = "Hellord";
    public string CardText { get; set; } = "# Card Text"; // Markdown
    public string CardTitle { get; set; } = "Card Title";

    public List<SelectListItem> ToSelectListItems()
    {
        List<SelectListItem> result = new List<SelectListItem>();
        foreach (ThreeDItem item in ThreeDFiles)
        {
            result.Add(new SelectListItem(item.ToString(), item.ToString() + "Value"));
        }
        return result;
    }

}