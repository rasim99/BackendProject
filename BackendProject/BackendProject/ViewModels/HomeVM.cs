using BackendProject.Models;

namespace BackendProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Banner> Banners { get; set; }
        public List<Category> Categories { get; set; }
        public List<ProductMenu> ProductMenus { get; set; }
        public List<Product> Products { get; set; }
        public List<SpecialProduct> SpecialProducts { get; set; }
        public List<SpecialProductWrapper> SpecialProductWrappers { get; set; }
        public List<Brand> Brands { get; set; }
        public List<FeaturesBanner> FeaturesBanners { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductProductMenu> ProductProductMenus { get; set; }

    }
}
