using Kolokwium2.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class FireBrigadeDbContext : DbContext
    {
        public DbSet<FireTruck> FireTrucks { get; set; }
        public DbSet<ActionEntity> Actions { get; set; }
        public DbSet<Firefighter> Firefighters { get; set; }
        public DbSet<FireTruckAction> FireTruckActions { get; set; }
        public DbSet<FirefighterAction> FirefighterActions { get; set; }
        public FireBrigadeDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new FireTruckEfConfiguration());
            modelBuilder.ApplyConfiguration(new ActionEntityEfConfiguration());
            modelBuilder.ApplyConfiguration(new FirefighterEfConfiguration());
            modelBuilder.ApplyConfiguration(new FireTruckActionEfConfiguration());
            modelBuilder.ApplyConfiguration(new FirefighterActionEfConfiguration());
        }
    }
}
