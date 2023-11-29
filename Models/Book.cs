﻿namespace WebApplication4.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Image>? images { get; set; }
        public int AuthorId { get; set; }
        public Author? author { get; set; }
        public int? CategoryId { get; set; }
        public Category? category { get; set; }
    }
}
