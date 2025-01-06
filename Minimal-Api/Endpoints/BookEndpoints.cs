using Microsoft.EntityFrameworkCore;
using Minimal_Api.Data;

namespace Minimal_Api.Endpoints
{
    public static class BookEndpoints
    {
        public static WebApplication MapBookEndpoints(this WebApplication app)
        {
            app.MapGet("/api/books", async (BookDbContext context) =>
              await context.Books.ToListAsync());

            app.MapGet("api/book/{Guid id}", async (BookDbContext context, Guid id) =>
            {
                var book = await context.Books.FindAsync(id);
                return book is null ? Results.NotFound() : Results.Ok(book);

            });
            return app;
        }
    }
}
