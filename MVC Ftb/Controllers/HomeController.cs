using Microsoft.AspNetCore.Mvc;
using MVC_Ftb.ViewModels;

namespace MVC_Ftb.Controllers
{
    public class HomeController : Controller
    {
        private readonly  AppDbContext _context;

        public HomeController(AppDbContext appContext)
        {
            _context = appContext;
        }


        public IActionResult Index()
        {
            HomeViewModels viewModels = new HomeViewModels();
            viewModels.Sliders = _context.Sliders.ToList();
            viewModels.Securities = _context.Securities.ToList();
            viewModels.Members = _context.Members.ToList();

            return View(viewModels);
        }
    }
}
