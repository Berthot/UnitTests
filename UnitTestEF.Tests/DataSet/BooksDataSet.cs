using System.Collections.Generic;
using UnitTest.Domain;
using UnitTest.Domain.Entity;

namespace UnitTestEF.Tests.DataSet
{
    public class BooksDataSet
    {
        public static List<Book> Data()
        {
            return new List<Book>()
            {
                new Book
                {
                    // Id = 0,
                    Title = "Clean Code",
                    Content = "Lorem ipsum dolor sit amet..",
                    AuthorId = 1,
                    CategoryId = (int) ECategories.Ti,
                    // CreatedAt = default
                }
            };
        }
    }
}