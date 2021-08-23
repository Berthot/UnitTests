using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.Infra.Repositories;
using UnitTestEF.Tests.Context;

namespace UnitTestEF.Tests.Services
{
    [TestClass]
    public class BookServiceTests
    {

        private readonly Repository _repository;

        public BookServiceTests()
        {
            _repository = new Repository(FakeContext.GetFakeContext());
        }
        
        
        
    }
}