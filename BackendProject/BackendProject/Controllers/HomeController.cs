using BackendProject.DAL;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
		{
			HomeVM homeVM = new HomeVM();
			homeVM.Sliders = _appDbContext.Sliders.ToList();
			homeVM.Banners = _appDbContext.Banners.ToList();
			homeVM.Categories = _appDbContext.Categories.ToList();
			homeVM.ProductMenus = _appDbContext.ProductMenus.ToList();
			homeVM.Products = _appDbContext.Products.ToList();
			homeVM.SpecialProducts = _appDbContext.SpecialProducts.ToList();
            homeVM.SpecialProductWrappers = _appDbContext.SpecialProductWrapper.ToList();
            homeVM.Brands = _appDbContext.Brands.ToList();
            homeVM.FeaturesBanners = _appDbContext.FeaturesBanners.ToList();
            homeVM.Blogs = _appDbContext.Blogs.ToList();
            homeVM.Testimonials = _appDbContext.Testimonials.ToList();

            return View(homeVM);
		}
	}
}
