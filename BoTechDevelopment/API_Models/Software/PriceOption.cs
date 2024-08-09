namespace BoTechDevelopment.API_Models.Software
{
    public class PriceOption
    {
        public int Id { get; set; }
        public double BusinessPrice { get; set; }
        public double StudentPrice { get; set; }
        public double PrivateUserPrice { get; set; }
    }
}
