using System;
using Microsoft.EntityFrameworkCore;
using UnitTest.Infra;
using UnitTestEF.Tests.DataSet;


namespace UnitTestEF.Tests.Context
{
    public class FakeContext
    {
        private static readonly DbContextOptions<UnitTest.Infra.Context> ContextOptions = new DbContextOptionsBuilder<UnitTest.Infra.Context>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        public static UnitTest.Infra.Context GetFakeContext()
        {
            var fakeContext = new UnitTest.Infra.Context(ContextOptions);
            AddAuthor(fakeContext);
            AddCategory(fakeContext);
            // AddBook(fakeContext);
            return fakeContext;
        }

        private static void AddAuthor(UnitTest.Infra.Context fakeContext)
        {
            fakeContext.Authors.AddRange(AuthorsDataSet.Data());
            fakeContext.SaveChanges();
        }
        private static void AddBook(UnitTest.Infra.Context fakeContext)
        {
            fakeContext.Books.AddRange(BooksDataSet.Data());
            fakeContext.SaveChanges();
        }
        
        private static void AddCategory(UnitTest.Infra.Context fakeContext)
        {
            fakeContext.Categories.AddRange(CategoriesDataSet.Data());
            fakeContext.SaveChanges();
        }
    }
}