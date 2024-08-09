namespace BoTechDevelopment.API_Models.Software.Update
{
    public interface IUpdateProgress
    {
        int progress { get; set; }
        string status { get; set; }
    }
}
