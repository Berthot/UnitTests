using System.Collections.Generic;
using UnitTest.Domain.Entity;

namespace UnitTest.Infra.Seed
{
    public static class SeedCategory
    {

        public static List<Category> StoreSeed()
        {
            return new List<Category>()
            {
                new Category
                {
                    Id = 1,
                    Name = "TI"
                },
                new Category
                {
                    Id = 2,
                    Name = "Adventure Fiction"
                },
                new Category
                {
                    Id = 3,
                    Name = "Proxy"
                }
            };
        }
    }
}