using BoTechDevelopment.Models.ThreeD_Library;

namespace BoTechDevelopment.ViewModels.ThreeD_Library;

public class SearchResults
{
    public string SearchText { get; set; } = null;
    public int Page { get; set; } = 1;
    public List<Post> Posts { get; set; } = new List<Post>();
}