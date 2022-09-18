using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
