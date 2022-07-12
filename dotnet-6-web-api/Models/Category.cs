


namespace dotnet_6_web_api.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        
        public virtual List<Product> Products { get; set; }
    }
}
