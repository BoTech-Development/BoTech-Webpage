using BoTechDevelopment.API_Models.Software;

namespace BoTechDevelopment.API_Models.LoginSystem
{
    public class UserComputer
    {
        
        public int Id { get; set; }
        public string ComputerName { get; set; } = string.Empty;
        public string ComputerID { get; set; } = string.Empty;
        public string UUID { get; set; } = string.Empty;
        public List<InstalledSoftware> InstalledSoftware { get; set; } = new();

    }
}
