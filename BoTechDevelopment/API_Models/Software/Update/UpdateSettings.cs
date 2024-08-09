namespace BoTechDevelopment.API_Models.Software.Update
{
    public class UpdateSettings
    {
        public int Id { get; set; }
        //The Client has to handle the old Files iwith these Parameters. 
        public List<string> FilesToDelete { get; set; } = new List<string>();
        public List<string> FilesToStay { get; set; } = new List<string>();
        //New Files can only be zip compressed Files. 
        public List<string> FilesToDownload { get; set; } = new List<string>();
        // These scripts must have been executed before the updater program started the update.
        //public List<RunOptions> PreInstallScripts { get; set; } = new List<RunOptions>();
        //These scripts must be executed when the update has finished.
        //public List<RunOptions> PostInstallScripts { get; set; } = new List<RunOptions>();
    }
}
