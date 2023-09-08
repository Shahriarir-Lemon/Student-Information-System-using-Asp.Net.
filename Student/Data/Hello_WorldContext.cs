using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hello_World.Models;

namespace Hello_World.Data
{
    public class Hello_WorldContext : DbContext
    {
        public Hello_WorldContext (DbContextOptions<Hello_WorldContext> options)
            : base(options)
        {
        }

        public DbSet<Hello_World.Models.Students> Students { get; set; }
    }
}
