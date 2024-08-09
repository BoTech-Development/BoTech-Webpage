namespace BoTechDevelopment.Helpers
{
    public class API_Client
    {
        private API_Client() { }
        private static API_Client Instance = null;
        public static API_Client getInstance()
        {
            if(Instance == null) Instance = new API_Client();
            return Instance;    
        }

    }
}
