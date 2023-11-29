using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.DAL;
using WebApplication4.Models;

namespace WebApplication4.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class BookController : Controller
    {
        AppDbContext _context;
        public BookController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Book> books = _context.Books.Include(p=>p.author)
                .Include(P=>P.category).ToList();
            return View(books);
        }
        public IActionResult Create()
        {
            ViewBag.authors = _context.Authors.ToList();
            ViewBag.categories= _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book books)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Books.Add(books);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            ViewBag.authors = _context.Authors.ToList();
            ViewBag.categories = _context.Categories.ToList();
            Book books = _context.Books.Find(id);
            return View(books);
        }
        [HttpPost]
        public IActionResult Update(Book newBook)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Book oldBook = _context.Books.Find(newBook.Id);
            oldBook.Title = newBook.Title;
            oldBook.Description = newBook.Description;
            oldBook.Price = newBook.Price;
            oldBook.AuthorId = newBook.AuthorId;
            oldBook.CategoryId = newBook.CategoryId;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Book book = _context.Books.Find(id);
            _context.Books.Remove(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
