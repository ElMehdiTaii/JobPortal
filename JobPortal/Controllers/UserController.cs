using JobPortal.Entities.DTOs.UserDto;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserForLoginDto userForLogin)
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult MyOffers()
        {
            return View();
        }
    }
}
