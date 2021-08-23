using System.Collections.Generic;
using UnitTest.Domain.Entity;

namespace UnitTest.Domain.Interface
{
    public interface IService
    {
        public Category GetCategory(string categoryName);
        Author GetAuthor(string author);
        public Book GetBookByName(string bookName);
        public List<Book> GetBooksByAuthors(string authorName);
        public void AddNewBook(string title, string url, string categoryName, string author);


    }
}