using BackendProject.DAL;
using BackendProject.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.ViewComponents
{
    public class NewsLettersViewComponent: ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public NewsLettersViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var newsletter = _appDbContext.NewsLetters.FirstOrDefault();
            return View(await Task.FromResult(newsletter));
        }
    }
}
