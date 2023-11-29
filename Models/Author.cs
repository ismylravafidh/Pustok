using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book>? books { get; set; }
    }
}
