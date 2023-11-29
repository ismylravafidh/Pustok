using Microsoft.AspNetCore.Mvc;
using WebApplication4.DAL;
using WebApplication4.Models;

namespace WebApplication4.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AuthorController : Controller
    {
        AppDbContext _context;
        public AuthorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Author> authors = _context.Authors.ToList();
            return View(authors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Authors.Add(author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            Author author = _context.Authors.Find(id);
            return View(author);
        }
        [HttpPost]
        public IActionResult Update(Author newAuthor)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Author oldAuthor = _context.Authors.Find(newAuthor.Id);
            oldAuthor.Name = newAuthor.Name;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Author author = _context.Authors.Find(id);
            _context.Authors.Remove(author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
