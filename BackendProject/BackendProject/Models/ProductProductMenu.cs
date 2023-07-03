namespace BackendProject.Models
{
    public class ProductProductMenu
    {
        public int Id { get; set; }
        public int ProductMenuId  { get; set; }
        public ProductMenu ProductMenu { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
