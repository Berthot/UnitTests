namespace UnitTest.Domain.Entity
{
    public class Category
    {
        public Category()
        {
        }

        public Category(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}