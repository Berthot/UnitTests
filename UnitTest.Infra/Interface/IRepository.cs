using System.Collections.Generic;
using UnitTest.Infra.Entity;

namespace UnitTest.Infra.Interface
{
    public interface IRepository
    {
        List<Message> GetMessages();
        List<Author> GetAuthors();
        Message GetMessageById(int id);
        Author GetAuthorById(int id);
        void AddAuthor(Author author);
        void AddMessage(Message message);

    }
}