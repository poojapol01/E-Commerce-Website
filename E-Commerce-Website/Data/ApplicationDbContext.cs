using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Website.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }
    }
}
