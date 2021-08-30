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
                    Title = "Quick Answers to Big Questions",
                    Url = "https://ler.amazon.com.br/kp/embed?asin=B07JVPCCWS&preview=newtab&linkCode=kpe&ref_=cm_sw_r_kb_dp_0V7D4V26CWMXJ1604R3J",
                    Author = new Author
                    {
                        Name = "Stephen Hawking",
                    },
                    CategoryId = (int) ECategories.Ti,
                }
            };
        }
    }
}