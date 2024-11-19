using System.ComponentModel.DataAnnotations;

namespace AppBooks.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        public string Comment { get; set; }

        public Book Book { get; set; }
    }
}
