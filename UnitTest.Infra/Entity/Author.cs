using System.Collections.Generic;

namespace UnitTest.Infra.Entity
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Message> Messages { get; set; }
    }
}