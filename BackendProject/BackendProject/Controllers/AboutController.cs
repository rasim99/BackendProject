using BackendProject.DAL;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public AboutController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            AboutVM AboutVM = new();
            AboutVM.Banners = _appDbContext.Banners.ToList();
            AboutVM.SpecialProducts = _appDbContext.SpecialProducts.ToList();
            AboutVM.SpecialProductWrappers = _appDbContext.SpecialProductWrapper.ToList();
            AboutVM.Brands = _appDbContext.Brands.ToList();
            AboutVM.FeaturesBanners = _appDbContext.FeaturesBanners.ToList();
            AboutVM.Blogs = _appDbContext.Blogs.ToList();
            AboutVM.Testimonials = _appDbContext.Testimonials.ToList();
            AboutVM.Abouts = _appDbContext.Abouts.FirstOrDefault();
            AboutVM.AboutItems = _appDbContext.AboutItems.ToList();
            return View(AboutVM);
        }

    }
}
