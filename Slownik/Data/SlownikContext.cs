using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Slownik.Entity;

namespace Slownik.Models
{
    public class SlownikContext : DbContext
    {
        public SlownikContext (DbContextOptions<SlownikContext> options)
            : base(options)
        {
        }

        public DbSet<Slownik.Entity.Slowa> Slowa { get; set; }
        public DbSet<Slownik.Entity.Ulubione> Ulubione { get; set; }
    }
}
