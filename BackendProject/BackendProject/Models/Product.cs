namespace BackendProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public List<ProductImage> Images { get; set; }
        public List<ProductProductMenu> ProductProductMenus { get; set; }
        public Product()
        {
            Images = new List<ProductImage>();
        }

    }
}
