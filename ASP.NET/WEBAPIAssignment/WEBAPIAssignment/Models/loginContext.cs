
using AspNetCoreWebApi6.Models;
using Microsoft.EntityFrameworkCore;
using WEBAPIAssignment.Models;
namespace WEBAPIAssignment.Models
{
    public class loginContext : DbContext
    {
        public loginContext(DbContextOptions<loginContext> options)
            : base(options)
        {
        }

        public DbSet<user> Users { get; set; } = null!;
    }
}
