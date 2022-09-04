using System.ComponentModel.DataAnnotations;

namespace qa.Entities
{
    public class Author
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string SurName { get; set; }
        public char Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Book> Books { get; set; } = new();
    }
}