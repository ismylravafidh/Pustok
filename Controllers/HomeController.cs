using Microsoft.AspNetCore.Mvc;
using WebApplication4.DAL;
using WebApplication4.Models;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliderList = new List<Slider>();
            List<Author> authorList = new List<Author>();
            List<Book> bookList = new List<Book>();
            List<Image> imageList = new List<Image>();

            HomeVm vm = new HomeVm();


            return View();
        }
    }
}
