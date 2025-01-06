using Microsoft.EntityFrameworkCore;
using Minimal_Api.Data;

namespace Minimal_Api.Endpoints
{
    public static class BookEndpoints
    {
        public static RouteGroupBuilder MapBookEndpoints(this RouteGroupBuilder groupBuilder)
        {
            groupBuilder.MapGet("/", async (BookDbContext context) =>
              await context.Books.ToListAsync());

            groupBuilder.MapGet("/{Guid id}", async (BookDbContext context, Guid id) =>
            {
                var book = await context.Books.FindAsync(id);
                return book is null ? Results.NotFound() : Results.Ok(book);

            });
            return groupBuilder;
        }
    }
}
