namespace BackendProject.Models
{
    public class ProductMenu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ProductProductMenu> ProductProductMenus { get; set; }

    }
}
