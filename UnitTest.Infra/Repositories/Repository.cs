using System.Collections.Generic;
using System.Linq;
using UnitTest.Infra.Entity;
using UnitTest.Infra.Interface;

namespace UnitTest.Infra.Repositories
{
    public class Repository : IRepository
    {
        private readonly Context _context;

        public Repository(Context context)
        {
            _context = context;
        }


        public List<Message> GetMessages()
        {
            return _context.Messages.ToList();
        }

        public List<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }

        public Message GetMessageById(int id)
        {
            return _context.Messages.FirstOrDefault(x => x.Id == id);
        }

        public Author GetAuthorById(int id)
        {
            return _context.Authors.FirstOrDefault(x => x.Id == id);
        }

        public void AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
        
        public void AddMessage(Message message)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
        }
    }
}