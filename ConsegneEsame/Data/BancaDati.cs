using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsegneEsame.Data
{
    public class BancaDati:DbContext
    {
        public DbSet<Piatto> piatti { get; set; }
        public BancaDati(DbContextOptions options) : base(options) { }
    }
}
