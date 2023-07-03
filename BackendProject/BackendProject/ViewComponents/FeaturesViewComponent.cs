using BackendProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class FeaturesViewComponent:ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public FeaturesViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var featuresBanners = _appDbContext.FeaturesBanners.ToList();
            return View(await Task.FromResult(featuresBanners));
        }
    }
}
