using System.Collections.Generic;
using UnitTest.Domain.Entity;
using UnitTest.Domain.Interface;

namespace UnitTestEF.Wrapper.Repositories
{
    public class FakeRepository : IRepository
    {
        public List<Message> GetMessages()
        {
            throw new System.NotImplementedException();
        }

        public List<Author> GetAuthors()
        {
            throw new System.NotImplementedException();
        }

        public Message GetMessageById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Author GetAuthorById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddAuthor(Author author)
        {
            throw new System.NotImplementedException();
        }

        public void AddMessage(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}