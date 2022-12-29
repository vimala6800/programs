using AspNetCoreWebApi6.Models;
using Microsoft.EntityFrameworkCore;
using WEBAPIAssignment.Models;
namespace WEBAPIAssignment.Models
{
    public class serviceContext : DbContext
    {
        public serviceContext(DbContextOptions<serviceContext> options)
            : base(options)
        {
        }

        public DbSet<serviceprovider> Serviceproviders { get; set; } = null!;
        public DbSet<user>users { get; set; } = null!;
    }
}