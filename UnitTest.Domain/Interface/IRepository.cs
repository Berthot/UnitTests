using System.Collections.Generic;
using UnitTest.Domain.Entity;

namespace UnitTest.Domain.Interface
{
    public interface IRepository
    {
        Category GetCategoryByName(string categoryName);
        Author GetAuthorByName(string authorName);
        Book GetBookByName(string bookName);
        List<Book> GetBooksByAuthor(string authorName);
        void AddBook(Book book);
        void AddAuthor(Author author);
        void AddCategory(Category category);
    }
}