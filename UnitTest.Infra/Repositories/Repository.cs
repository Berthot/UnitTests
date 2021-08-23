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


        public Category GetCategoryByName(string categoryName)
        {
            return _context.Categories.FirstOrDefault(x => x.Name.ToLower() == categoryName);
        }

        public Author GetAuthorByName(string authorName)
        {
            return _context.Authors.FirstOrDefault(x => x.Name.ToLower() == authorName.ToLower());

        }

        public Book GetBookByName(string bookName)
        {
            return _context.Books.FirstOrDefault(x => x.Title.ToLower() == bookName.ToLower());

        }

        public List<Book> GetBooksByAuthor(string authorName)
        {
            return _context.Books
                .Where(x => x.Author.Name.ToLower() == authorName.ToLower())
                .ToList();

        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
    }
}