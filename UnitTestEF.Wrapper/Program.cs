using System;
using UnitTest.Infra;
using UnitTest.Infra.Entity;
using UnitTest.Infra.Interface;
using UnitTest.Infra.Repositories;

namespace UnitTestEF.Wrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new Repository(new Context());

            var aut = new Author();
            
            repo.AddAuthor(aut);

            Console.WriteLine(aut.Id);
        }
    }
}