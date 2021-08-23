using System.Collections.Generic;
using UnitTest.Domain.Entity;

namespace UnitTest.Domain.Interface
{
    public interface IRepository
    {
        List<Book> GetBooks();
        List<Author> GetAuthors();
        Book GetBookById(int id);
        Author GetAuthorById(int id);
        void AddAuthor(Author author);
        void AddBook(Book book);

    }
}