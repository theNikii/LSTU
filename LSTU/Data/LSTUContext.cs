using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LSTU.Models;

namespace LSTU.Data
{
    public class LSTUContext : DbContext
    {
        public LSTUContext (DbContextOptions<LSTUContext> options)
            : base(options)
        {
        }

        public DbSet<LSTU.Models.Users> User { get; set; } = default!;
        public DbSet<LSTU.Models.Items> Items { get; set; } = default!;
    }
}
