using System.ComponentModel.DataAnnotations;

namespace BackendProject.ViewModels.AdminVM
{
    public class ProductVM
    {
        [Required, StringLength(100)]
        public string Name { get; set; }
        public List<int> ProductMenuIds { get; set; }

        [Range(0, 30)]
        public int Count { get; set; }
        public double Price { get; set; }
        [Required]
        public IFormFile[] Photos { get; set; }
    }
}
