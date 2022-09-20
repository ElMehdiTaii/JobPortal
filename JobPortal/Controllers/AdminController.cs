using JobPortal.Contracts;
using JobPortal.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        public AdminController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _repositoryWrapper.UsersRepository.
                GetAllUsers();

            return View(result);
        }
    }
}
