using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
