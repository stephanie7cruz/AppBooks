using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppBooks.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public string Summary { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
