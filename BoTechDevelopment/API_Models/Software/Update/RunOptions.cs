namespace BoTechDevelopment.API_Models.Software.Update
{
    public class RunOptions
    {
        public int Id { get; set; }
        //public IScript Script { get; set; }
        public List<string> options { get; set; } = new List<string>();
    }
}
