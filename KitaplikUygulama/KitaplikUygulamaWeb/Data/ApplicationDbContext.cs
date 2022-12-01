using KitaplikUygulamaWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace KitaplikUygulamaWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        
        }

        public DbSet<Category> Categories { get; set; }
    }
   
}
