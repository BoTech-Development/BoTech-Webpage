

namespace BoTechDevelopment.API_Models.Software.Update
{
    public class Version
    {
        public int Id { get; set; }
        public int Major { get; set; } = 0;
        public int Minor { get; set; } = 0;
        public int Patch { get; set; } = 0;
        public int SecondPatch { get; set; }
        public EUpdateRevision UpdateRevision { get; set; } = EUpdateRevision.Beta;
        public EUpdateMode UpdateMode { get; set; } = EUpdateMode.None;
        public string Description { get; set; } = string.Empty;
        public DateTime Published { get; set; } = DateTime.MinValue;
        public DateTime AvailableUntil { get; set; } = DateTime.MinValue;
        public UpdateSettings UpdateSetting { get; set; } = new UpdateSettings();

        public Version()
        {

        }
        // Retunrs Something like this v1.2.3.4
        public string ToVersionString()
        {
            string result = "v";
            result += Major + ".";
            result += Minor + ".";
            result += Patch;
            if (SecondPatch != -1) result += "." + SecondPatch;
            return result;
        }
        public bool isHigherThan(Version otherVersion)
        {
            if (this.Major > otherVersion.Major) return true;
            if (this.Minor > otherVersion.Minor) return true;
            if (this.Patch > otherVersion.Patch) return true;
            if (this.SecondPatch != -1 && otherVersion.SecondPatch != -1)
            {
                if (this.SecondPatch > otherVersion.SecondPatch) return true;
            }
            return false;
        }
        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                if (obj is Version)
                {
                    return this.Id == ((Version)obj).Id && this.Major == ((Version)obj).Major && this.Minor == ((Version)obj).Minor && this.Patch == ((Version)obj).Patch && this.SecondPatch == ((Version)obj).SecondPatch && this.UpdateRevision == ((Version)obj).UpdateRevision && this.UpdateMode == ((Version)obj).UpdateMode && this.Description.Equals(((Version)obj).Description) && this.Published.Equals(((Version)obj).Published) && this.AvailableUntil.Equals(((Version)obj).AvailableUntil) && this.UpdateSetting.Equals(((Version)obj).UpdateSetting);
                }
            }
            return false;
        }
        public bool Equals(Version otherVersion)
        {
            if (otherVersion != null)
            {
                if (this.Major == otherVersion.Major && this.Minor == otherVersion.Minor && this.Patch == otherVersion.Patch)
                {
                    if (this.SecondPatch != -1 && otherVersion.SecondPatch != -1)
                    {
                        if (this.SecondPatch == otherVersion.SecondPatch) return true;
                    }
                    return true;

                }
            }
            return false;
        }
        public bool isLowerThan(Version otherVersion)
        {
            if (this.Major < otherVersion.Major) return true;
            if (this.Minor < otherVersion.Minor) return true;
            if (this.Patch < otherVersion.Patch) return true;
            if (this.SecondPatch != -1 && otherVersion.SecondPatch != -1)
            {
                if (this.SecondPatch < otherVersion.SecondPatch) return true;
            }
            return false;
        }
    }
}
