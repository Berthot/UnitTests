using System.Collections.Generic;
using System.Linq;
using UnitTest.Domain.Entity;
using UnitTest.Domain.Interface;

namespace UnitTest.Infra.Repositories
{
    public class Repository : IRepository
    {
        private readonly Context _context;

        public Repository(Context context)
        {
            _context = context;
        }


        public List<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public List<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(x => x.Id == id);
        }

        public Author GetAuthorById(int id)
        {
            return _context.Authors.FirstOrDefault(x => x.Id == id);
        }

        public void AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
        
        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
    }
}