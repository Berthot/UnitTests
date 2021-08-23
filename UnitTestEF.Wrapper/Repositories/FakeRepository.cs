using System.Collections.Generic;
using UnitTest.Domain.Entity;
using UnitTest.Domain.Interface;

namespace UnitTestEF.Wrapper.Repositories
{
    public class FakeRepository : IRepository
    {
        public List<Book> GetBooks()
        {
            throw new System.NotImplementedException();
        }

        public List<Author> GetAuthors()
        {
            throw new System.NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Author GetAuthorById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddAuthor(Author author)
        {
            throw new System.NotImplementedException();
        }

        public void AddBook(Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}