using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.Domain.Services;
using UnitTest.Infra.Repositories;
using UnitTestEF.Tests.Context;

namespace UnitTestEF.Tests.Services
{
    [TestClass]
    public class BookServiceTests
    {
        private readonly Service _service;


        public BookServiceTests()
        {
            var repo = new Repository(FakeContext.GetFakeContext());
            _service = new Service(repo);
        }
        
        [TestMethod]
        [DataRow("robert c martin")]
        [DataRow("pai joao")]
        public void GET_AUTHOR(string authorName)
        {
            _service.CreateNewAuthor(authorName);
        
            var author = _service.GetAuthor(authorName);
            
            Assert.IsNotNull(author.Id);

        }

        [TestMethod]
        [DataRow("robert c martin", "Clean Code")]
        [DataRow("pai joao", "It magics")]
        public void CREATE_NEW_BOOK(string authorName, string title)
        {
            _service.GetAuthor(authorName);

            var book = _service.CreateNewBook(
                title: title,
                url: "www.url_aleatoria.com",
                categoryName: "proxy",
                authorName: authorName
            );
            
            Assert.IsNotNull(book.Id);

        }
        
        
        [TestMethod]
        [DataRow("Clean Code")]
        public void GET_BOOK_BY_NAME(string bookName)
        {
            _service.GetAuthor("robert c martin");

            var book = _service.CreateNewBook(
                title: bookName,
                url: "www.url_aleatoria.com",
                categoryName: "proxy",
                authorName: "robert c martin"
            );

            var getBook = _service.GetBookByName(bookName);
            
            Assert.IsNotNull(getBook.Id);

        }
    }
}