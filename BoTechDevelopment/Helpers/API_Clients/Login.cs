using BoTechDevelopment.Models.LoginSystem.Backend;
using BoTechDevelopment.Models.LoginSystem.Frontend;

namespace BoTechDevelopment.Helpers.API_Clients
{
    public class Login
    {
        private Login() { }
        private static Login Instance = null;
        public static Login getInstance()
        {
            if (Instance == null) Instance = new Login();
            return Instance;
        }

        
    }
}
