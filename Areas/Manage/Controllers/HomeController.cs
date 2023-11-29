using Microsoft.AspNetCore.Mvc;
using WebApplication4.DAL;

namespace WebApplication4.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class HomeController : Controller
    {
        AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
