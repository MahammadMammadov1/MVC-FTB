using Microsoft.EntityFrameworkCore;
using MVC_Ftb.Models;

namespace MVC_Ftb
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<Security> Securities { get; set; }
        public DbSet<Members> Members { get; set; }

    }
}
