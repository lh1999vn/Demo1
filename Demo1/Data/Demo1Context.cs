using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo1.Models;

namespace Demo1.Data
{
    public class Demo1Context : DbContext
    {
        public Demo1Context (DbContextOptions<Demo1Context> options)
            : base(options)
        {
        }

        public DbSet<Demo1.Models.Product> Product { get; set; } = default!;

        public DbSet<Demo1.Models.Category>? Category { get; set; }

        public DbSet<Demo1.Models.User>? User { get; set; }
    }
}
