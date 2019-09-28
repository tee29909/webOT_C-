using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OT.Models
{
    public class OTContext : DbContext
    {
        public OTContext (DbContextOptions<OTContext> options)
            : base(options)
        {
        }

        public DbSet<OT.Models.Emp> Emp { get; set; }
    }
}
