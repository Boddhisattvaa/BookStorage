using System.ComponentModel.DataAnnotations;

namespace qa.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        [MaxLength(500)]
        public string Annotation { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public List<Author> Authors { get; set; } = new();
    }
}