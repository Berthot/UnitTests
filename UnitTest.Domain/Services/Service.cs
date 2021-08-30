using System;
using System.Collections.Generic;
using UnitTest.Domain.Entity;
using UnitTest.Domain.Interface;

namespace UnitTest.Domain.Services
{
    public class Service : IService
    {
        private readonly IRepository _repo;

        public Service(IRepository repo)
        {
            _repo = repo;
        }

        public Category GetCategory(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
                throw new Exception("Category name is null or empty");

            var category = _repo.GetCategoryByName(categoryName);

            return category;
        }

        public Author GetAuthor(string authorName)
        {
            if (string.IsNullOrEmpty(authorName))
                throw new Exception("Author name is null or empty");

            var author = _repo.GetAuthorByName(authorName);

            return author;
        }

        public Book GetBookByName(string bookName)
        {
            if (string.IsNullOrEmpty(bookName))
                throw new Exception("Book name is null or empty");

            var book = _repo.GetBookByName(bookName);

            if (book != default) return book;
            
            Console.WriteLine("not covered");
            Console.WriteLine("not covered");
            Console.WriteLine("not covered");
            throw new Exception($"book [{bookName}] not found book");
        }

        public List<Book> GetBooksByAuthors(string authorName)
        {
            if (string.IsNullOrEmpty(authorName))
                throw new Exception("Author name is null or empty");

            var books = _repo.GetBooksByAuthor(authorName);

            return books;
        }

        public Book CreateNewBook(string title, string url, string categoryName, string authorName)
        {
            var category = GetCategory(categoryName.ToLower());

            if (category == default) throw new Exception("category error");

            var author = GetAuthor(authorName);

            if (author == default) throw new Exception("author error");

            var book = new Book
            {
                Title = title,
                Url = url,
                Author = author,
                Category = category,
            };

            _repo.AddBook(book);
            return book;
        }

        public void CreateNewAuthor(string authorName)
        {
            _repo.AddAuthor(new Author
            {
                Books = new List<Book>(),
                Name = authorName,
            });
        }

        public void CreateNewCategory(string proxy)
        {
            _repo.AddCategory(new Category()
            {
                Name = proxy,
            });
        }
    }
}