using JobPortal.Entities.DTOs.RecruiterDto;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class RecruiterController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(RecruiterForLoginDto recruiterForLogin)
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult CreateOffer()
        {
            return View();
        }
        public IActionResult EditOffer()
        {
            return View();
        }
        public IActionResult CandidatesLists()
        {
            return View();
        }
        public IActionResult MyOffers()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
