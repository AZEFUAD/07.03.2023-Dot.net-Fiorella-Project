using Fiorella.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<AboutIntroComponent> AboutIntroComponents { get; set; }
    }
}
