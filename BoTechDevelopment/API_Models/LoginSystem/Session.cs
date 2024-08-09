namespace BoTechDevelopment.API_Models.LoginSystem
{
    public class Session
    {
        public int Id { get; set; }
        public string ClientHostName { get; set; } = string.Empty;
        public string ClientIpAdress { get; set; } = string.Empty;
        public DateTime Created {  get; set; }
        public bool Valid { get; set; } 
        public string UUID { get; set; } = string.Empty;
    }
}
