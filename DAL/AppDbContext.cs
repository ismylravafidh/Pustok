using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
