using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
