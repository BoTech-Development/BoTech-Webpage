namespace BoTechDevelopment.API_Models.Software
{
    public interface IProduct 
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        PriceOption Price { get; set; }
        Category Category { get; set; }
    }
}
