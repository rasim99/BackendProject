using BackendProject.DAL;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class ProductPartViewComponent :ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public ProductPartViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HomeVM homeVM = new();
            homeVM.ProductMenus = _appDbContext.ProductMenus.ToList();
            homeVM.ProductProductMenus = _appDbContext.ProductProductMenus.ToList();
            homeVM.Products = _appDbContext.Products.ToList();
            return View(await Task.FromResult(homeVM));
        }
    }
}
