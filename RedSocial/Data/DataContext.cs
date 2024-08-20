using Microsoft.EntityFrameworkCore;
using RedSocial.Entities;

namespace RedSocial.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        
        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}
