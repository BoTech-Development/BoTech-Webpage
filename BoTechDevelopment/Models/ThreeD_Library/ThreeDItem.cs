using Version = BoTechDevelopment.API_Models.Software.Update.Version;

namespace BoTechDevelopment.Models.ThreeD_Library;

public class ThreeDItem
{
    public List<string> Files { get; set; } = new List<string>();
    public Version Version { get; set; } = new Version();
    public override string ToString()
    {
        return Version.ToVersionString();
    }
}