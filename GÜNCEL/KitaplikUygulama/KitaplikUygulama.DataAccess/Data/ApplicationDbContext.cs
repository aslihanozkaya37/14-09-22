using KitaplikUygulama.Models;
using Microsoft.EntityFrameworkCore;

namespace KitaplikUygulama.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        
        }

        public DbSet<Category> Categories { get; set; }
    }
   
}
