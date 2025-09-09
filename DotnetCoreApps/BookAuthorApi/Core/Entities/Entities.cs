using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAuthorApi.Core.Entities
{
    [Table("AuthorTable")]
    public class Author
    {
        public ICollection<Book> Books { get; set; } = new List<Book>();
        [Column("AuthorName")]
        public required string Name { get; set; }
        [Key]
        public int AuthorId { get; set; }
    }

    [Table("BookTable")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Column("Title")]
        [Required]
        public required string Title { get; set; }
        [Column("BookPrice")]
        [Required]
        public double BookPrice { get; set; }
        [Column("AuthorId")]
        [Required]
        public int AuthorId { get; set; }
        public required Author Author { get; set; }
    }
 
}
