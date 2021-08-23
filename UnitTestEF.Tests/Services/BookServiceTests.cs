using NUnit.Framework;
using UnitTest.Domain.Services;
using UnitTest.Infra.Repositories;
using UnitTestEF.Tests.Context;

namespace UnitTestEF.Tests.Services
{
    public class BookServiceTests
    {
        private Service _service;
        private UnitTest.Infra.Context _context;
        private Repository _repo;


        [SetUp]
        public void SetUp()
        {
            _context = FakeContext.GetFakeContext();
            _repo = new Repository(_context);
            _service = new Service(_repo);
        }

        [Test]
        [TestCase("robert c martin")]
        [TestCase("pai joao")]
        public void GET_AUTHOR(string authorName)
        {
            _service.CreateNewAuthor(authorName);

            var author = _service.GetAuthor(authorName);

            Assert.IsNotNull(author.Id);
        }

        [Test]
        [TestCase("robert c martin", "Clean Code")]
        [TestCase("pai joao", "It magics")]
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


        [Test]
        [TestCase("Clean Code")]
        public void GET_BOOK_BY_NAME(string bookName)
        {
            var getBook = _service.GetBookByName(bookName);

            Assert.IsNotNull(getBook.Id);
        }
    }
}