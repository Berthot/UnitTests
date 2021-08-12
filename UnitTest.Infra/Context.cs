using System;
using Microsoft.EntityFrameworkCore;
using UnitTest.Domain.Entity;

namespace UnitTest.Infra
{
    public class Context: DbContext
    {
        public virtual DbSet<Message> Messages { get; set; }

        public virtual DbSet<Author> Authors { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Author>().Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(); 
            
            builder.Entity<Message>().Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(); 
            
            
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=idkfa123;Database=testing;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}