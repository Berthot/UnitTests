using System.Collections.Generic;
using UnitTest.Domain.Entity;

namespace UnitTestEF.Tests.DataSet
{
    public static class AuthorsDataSet
    {
        public static List<Author> Data()
        {
            return new List<Author>()
            {
                new Author()
                {
                    // Id = 1,
                    Books = new List<Book>(),
                    Name = "robert c martin"
                },
                new Author()
                {
                    // Id = 2,
                    Books = new List<Book>(),
                    Name = "pai joao"
                }
            };
        }
    }
}