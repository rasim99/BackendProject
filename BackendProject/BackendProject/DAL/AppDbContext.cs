
using BackendProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.DAL
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}
		 public DbSet<Bio> Bios { get; set; }
		 public DbSet<Slider> Sliders { get; set; }
		 public DbSet<Banner> Banners { get; set; }
		 public DbSet<Category> Categories { get; set; }
		 public DbSet<ProductMenu> ProductMenus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SpecialProduct> SpecialProducts { get; set; }
        public DbSet<SpecialProductWrapper> SpecialProductWrapper { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<FeaturesBanner> FeaturesBanners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
