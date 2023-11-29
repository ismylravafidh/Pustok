using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class HomeVm
    {
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
        public List<Image> Images { get; set; }
        public List<Slider> Sliders { get; set; }
    }
}
