
using BoTechDevelopment.API_Models.Software.Update.Scripting;

namespace BoTechDevelopment.API_Models.Software.Update
{
    public class BackingUpFiles : IUpdateProgress, IScript
    {
        public int progress { get; set; } = 0;
        public string status { get; set; } = "BackingUpFiles: INIT...";

    }
}
