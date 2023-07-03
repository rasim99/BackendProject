using BackendProject.Models;

namespace BackendProject.ViewModels
{
    public class AboutVM
    {
        public List<Brand> Brands { get; set; }
        public List<FeaturesBanner> FeaturesBanners { get; set; }


        public List<Banner> Banners { get; set; }
        public List<SpecialProduct> SpecialProducts { get; set; }
        public List<SpecialProductWrapper> SpecialProductWrappers { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public About Abouts { get; set; }
        public List<AboutItem> AboutItems { get; set; }


    }
}
