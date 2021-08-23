using Microsoft.EntityFrameworkCore;
using UnitTest.Domain.Entity;

namespace UnitTest.Infra
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> builderOptions) : base(builderOptions)
        {
        }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Author> Authors { get; set; }
        
        public virtual DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Author>().Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            
            builder.Entity<Category>().Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Entity<Book>().Property(x => x.CreatedAt)
                .HasDefaultValueSql("now()");
            
            base.OnModelCreating(builder);
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=kazen;Password=kazen@2021;Database=test;");
        //     base.OnConfiguring(optionsBuilder);
        // }
    }
}