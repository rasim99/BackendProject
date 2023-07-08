using BackendProject.DAL;
using BackendProject.Helper;
using BackendProject.Models;
using BackendProject.ViewModels.AdminVM;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Areas.AdminArea.Controllers
{
    [Area(nameof(AdminArea))]
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
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
        public IActionResult Create()
        {
            ViewBag.ProMenu = new SelectList(_appDbContext.ProductMenus.ToList(), "Id", "Title");

            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(ProductVM productVM)
        {
            ViewBag.ProMenu = new SelectList(_appDbContext.ProductMenus.ToList(), "Id", "Title");

            if (!ModelState.IsValid) return NotFound();
            Product product = new();

            List<ProductProductMenu> proProductMenus = new List<ProductProductMenu>();
            foreach (var item in productVM.ProductMenuIds)
            {
                ProductProductMenu productProductMenu = new();
                productProductMenu.ProductId = product.Id;
                productProductMenu.ProductMenuId = item;
                proProductMenus.Add(productProductMenu);
            }
            product.ProductProductMenus = proProductMenus;
            foreach (var item in productVM.Photos)
            {
                if (!item.CheckFileType())
                {
                    ModelState.AddModelError("Photos", "wrong format");
                    return View();
                }
                if (item.ChechkFileSize(1000))
                {
                    ModelState.AddModelError("Photos", "small size");
                    return View();
                }
                ProductImage image = new();
                if (item == productVM.Photos[0])
                {
                    image.Ismain = true;
                }
                image.ImageUrl = item.SaveImage(_webHostEnvironment, "images","product");
                product.Images.Add(image);
            }
            product.Title = productVM.Name;
            product.Price = productVM.Price;
            _appDbContext.Products.Add(product);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
