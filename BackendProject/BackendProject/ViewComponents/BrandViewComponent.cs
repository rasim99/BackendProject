using BackendProject.DAL;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class BrandViewComponent : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public BrandViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var brands = _appDbContext.Brands.ToList();
            return View(await Task.FromResult(brands));
        }
    }
}
