using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaWeb.Models
{
    public class SistemaWebContext : DbContext
    {
        public SistemaWebContext (DbContextOptions<SistemaWebContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaWeb.Models.Department> Department { get; set; }
    }
}
