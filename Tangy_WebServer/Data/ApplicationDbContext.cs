using Microsoft.EntityFrameworkCore;

namespace Tangy_WebServer.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Category>? Categories { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
}