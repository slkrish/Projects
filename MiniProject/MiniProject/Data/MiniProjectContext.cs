using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniProject.Models;

namespace MiniProject.Data
{
    public class MiniProjectContext : DbContext
    {
        public MiniProjectContext (DbContextOptions<MiniProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MiniProject.Models.Product> Product { get; set; }
    }
}
