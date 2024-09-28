using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data
{
    public class BookstoreDbContext : DbContext 
    {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }

    }
}
