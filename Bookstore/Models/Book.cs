using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string Genre { get; set; }

    }
}
