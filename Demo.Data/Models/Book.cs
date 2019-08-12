using System;
using System.Collections.Generic;

namespace Demo.Data.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public int? Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int? CategoryId { get; set; }
        public int? AuthorId { get; set; }
    }
}
