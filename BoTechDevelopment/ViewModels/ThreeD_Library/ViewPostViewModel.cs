using BoTechDevelopment.Models.ThreeD_Library;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BoTechDevelopment.ViewModels.ThreeD_Library;

public class ViewPostViewModel
{
    public Post Post { get; set; } = new Post();
    public int SelectedVersion { get; set; } = 0;
    public int SelectedFile { get; set; } = 0;

    public IEnumerable<SelectListItem> GetSelectedListItemsForVersions()
    {
        int id = 0;
        List<SelectListItem> result = new List<SelectListItem>();
        foreach (ThreeDItem item in Post.ThreeDFiles)
        {
            result.Add(new SelectListItem
            {
                Value = id.ToString(),
                Text = item.Version.ToVersionString()
            });
            id++;
        }
        return result;
    }
    public IEnumerable<SelectListItem> GetSelectedListItemsForFiles(int currentVersion)
    {
        int id = 0;
        List<SelectListItem> result = new List<SelectListItem>();
        foreach (string file in Post.ThreeDFiles[currentVersion].Files)
        {
            result.Add(new SelectListItem
            {
                Value = id.ToString(),
                Text = file.Substring(file.LastIndexOf("/"), file.Length - file.LastIndexOf("/"))
            });
            id++;
        }
        return result;
    }
}