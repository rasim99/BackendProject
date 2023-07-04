using BackendProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Areas.AdminArea.Controllers
{
    [Area(nameof(AdminArea))]
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var query = _appDbContext.Products.AsQueryable();
            var products=query
                .Include(q=>q.Images)
                .Include(q=>q.ProductProductMenus)
                .ThenInclude(q=>q.ProductMenu)
                .ToList();
            return View(products);
        }
    }
}
