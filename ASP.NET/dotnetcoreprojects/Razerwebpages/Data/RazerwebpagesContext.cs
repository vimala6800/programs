using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razerwebpages.Models;

namespace Razerwebpages.Data
{
    public class RazerwebpagesContext : DbContext
    {
        public RazerwebpagesContext (DbContextOptions<RazerwebpagesContext> options)
            : base(options)
        {
        }

        public DbSet<Razerwebpages.Models.Movie> Movie { get; set; } = default!;
    }
}
