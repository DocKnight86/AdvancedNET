﻿namespace Bookstore.Models
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }
        public string AuthorFirst { get; set; } = null!;
        public string AuthorLast { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
