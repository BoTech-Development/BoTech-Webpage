
using Version = BoTechDevelopment.API_Models.Software.Update.Version;
namespace BoTechDevelopment.API_Models.Software
{
    public class InstalledSoftware
    {
        public int Id { get; set; }
        public SoftwareProduct RefToActualProduct { get; set; } = new();
        public Version InstalledVersion { get; set; } = new();
        public DateTime InstalledTime {  get; set; } 

    }
}
