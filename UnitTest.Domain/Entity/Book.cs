using System;

namespace UnitTest.Domain.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Url { get; set; }

        public int AuthorId { get; set; }
        
        public int CategoryId { get; set; }
        public virtual Author Author { get; set; }
        
        public virtual Category Category { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}