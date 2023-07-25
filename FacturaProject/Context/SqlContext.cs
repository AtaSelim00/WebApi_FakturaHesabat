using FacturaProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturaProject.Context
{
    public class SqlContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-689VM7L;Database=Faktura;Trusted_Connection=True");
        }

        public DbSet<FakturaBody> FakturaBody { get; set; }
        public DbSet<FakturaHeader> FakturaHeader { get; set; }
    }
}
