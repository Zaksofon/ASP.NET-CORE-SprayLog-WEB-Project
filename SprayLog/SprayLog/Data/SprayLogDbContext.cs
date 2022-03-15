using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SprayLog.Data.Models;

namespace SprayLog.Data
{
    public class SprayLogDbContext : IdentityDbContext
    {
        public SprayLogDbContext(DbContextOptions<SprayLogDbContext> options)
            : base(options)
        {
        }

        public DbSet<Plot> Plots { get; init; }
        public DbSet<Crop> Crops { get; init; }
    }
}
