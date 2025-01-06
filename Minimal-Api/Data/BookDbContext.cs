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
                new Book { Description = "Book 1 Description", Id = System.Guid.NewGuid(), Name = "Book 1" },
                new Book { Description = "Book 2 Description", Id = System.Guid.NewGuid(), Name = "Book 2" },
                new Book { Description = "Book 3 Description", Id = System.Guid.NewGuid(), Name = "Book 3" }
                );
        }
    }
}
