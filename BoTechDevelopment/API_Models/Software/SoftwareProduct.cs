using BoTechDevelopment.API_Models.Software.Update;
using Version = BoTechDevelopment.API_Models.Software.Update.Version;

namespace BoTechDevelopment.API_Models.Software
{
    public class SoftwareProduct : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public PriceOption Price { get; set; } = new();
        public Category Category { get; set; } = new Category();
        public Version CurrentVersion { get; set; } = new Version();
        public List<Version> VersionHistory { get; set; } = new List<Version>();
        public EProductType ProductType { get; set; }
    }
}
