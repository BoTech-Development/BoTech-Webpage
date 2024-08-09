
using System.ComponentModel.DataAnnotations;

namespace BoTechDevelopment.API_Models.Software
{
    public class Category
    {
        [Key]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        //public List<Tag> tags = new List<Tag>();

    }
}
