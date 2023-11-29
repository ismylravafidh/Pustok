namespace WebApplication4.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public int BookId { get; set; }
        public Book? book { get; set; }
    }
}
