using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Polly;
using UnitTest.Domain.Entity;

namespace UnitTestEF.Tests
{
    [TestClass]
    public class UnitTests
    {
        public UnitTests()
        {
            var fakeContext = new Mock<Context>();

            IList<Message> messages = new List<Message>() {
                new Message()
                {
                    Author = new Author()
                    {
                        Name = "Arthur"
                    },
                    Text = "arroz doce"
                }
            };
            
            // fakeContext.SetupSequence(x=>x.Set<Message>()).
        }
        
        [TestMethod]
        public void GetMessage()
        {
        }
    }
}