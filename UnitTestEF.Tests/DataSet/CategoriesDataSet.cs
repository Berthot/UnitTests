using System.Collections.Generic;
using UnitTest.Domain.Entity;

namespace UnitTestEF.Tests.DataSet
{
    public class CategoriesDataSet
    {
        public static List<Category> Data()
        {
            return new List<Category>()
            {
                new Category(name: "TI"),
                new Category(name: "Adventure Fiction"),
                new Category(name: "Proxy")
            };
        }
    }
}