using Microsoft.EntityFrameworkCore;
using Minimal_Api.Data;
using Minimal_Api.Model;

namespace Minimal_Api.Endpoints
{
    public static class BookEndpoints
    {
        public static RouteGroupBuilder MapBookEndpoints(this RouteGroupBuilder groupBuilder)
        {
            groupBuilder.MapGet("/", async (BookDbContext context) =>
              await context.Books.ToListAsync());

            groupBuilder.MapGet("/{id:guid}", async (BookDbContext context, Guid id) =>
            {
                var book = await context.Books.FindAsync(id);
                return book is null ? Results.NotFound() : Results.Ok(book);

            });

            groupBuilder.MapPost("/", async (BookDbContext context, Book book) =>
            {
                if (book is null)
                    return Results.BadRequest("Book is null");

                context.Books.Add(book);
                await context.SaveChangesAsync();
                return Results.Created($"/{book.Id}", book);
            });
            return groupBuilder;
        }
    }
}
