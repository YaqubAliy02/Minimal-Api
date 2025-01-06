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

            return app;
        }
    }
}
