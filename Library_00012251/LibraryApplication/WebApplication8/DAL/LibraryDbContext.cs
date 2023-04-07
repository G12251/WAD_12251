using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;

namespace LibraryApplication.DAL
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}