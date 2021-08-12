namespace UnitTest.Domain.Entity
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual Author Author { get; set; }
        
        public int AuthorId { get; set; }
    }
}