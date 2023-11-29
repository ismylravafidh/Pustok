using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required,StringLength(10)]
        public string Name { get; set; }
        List<Book>? Books { get; set; }
    }
}
