using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
