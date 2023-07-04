using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Areas.AdminArea.Controllers
{
    [Area(nameof(AdminArea))]

    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
