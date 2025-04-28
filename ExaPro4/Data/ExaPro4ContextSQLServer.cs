using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExaPro4.Models;

namespace ExaPro4.Data
{
    public class ExaPro4ContextSQLServer : DbContext
    {
        public ExaPro4ContextSQLServer (DbContextOptions<ExaPro4ContextSQLServer> options)
            : base(options)
        {
        }

        public DbSet<ExaPro4.Models.Cliente> Cliente { get; set; } = default!;
    }
}
