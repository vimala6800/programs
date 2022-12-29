using Microsoft.EntityFrameworkCore;
using WEBAPIAssignment.Models;

namespace AspNetCoreWebApi6.Models
{
    public class userContext : DbContext
    {
        public userContext(DbContextOptions<userContext> options)
            : base(options)
        {
        }

        public DbSet<user> Users { get; set; } = null!;
    }
}
