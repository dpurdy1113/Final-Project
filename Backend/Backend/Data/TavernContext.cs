using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class TavernContext : DbContext
    {
        public TavernContext (DbContextOptions<TavernContext> options)
            : base(options)
        {
        }

        public DbSet<Backend.Models.Tavern> Tavern { get; set; }
    }
}
