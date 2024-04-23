using Microsoft.EntityFrameworkCore;

namespace CsharpCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Language> Language { get; set; }
    }
}

