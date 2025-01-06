using Microsoft.EntityFrameworkCore;
using Minimal_Api.Model;

namespace Minimal_Api.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
     new Book { Description = "Book 1 Description", Id = Guid.Parse("d7a09af2-dc8b-4fa4-93d1-c68df8c51753"), Name = "Book 1" },
     new Book { Description = "Book 2 Description", Id = Guid.Parse("6c5c55d3-4f54-4b90-80d4-d43b9b524d8a"), Name = "Book 2" },
     new Book { Description = "Book 3 Description", Id = Guid.Parse("e6d5b92f-3ac1-4c69-a717-5c0c75091649"), Name = "Book 3" }
 );

        }
    }
}
