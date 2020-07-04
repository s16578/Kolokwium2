using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Configuration
{
    public class FireTruckActionEfConfiguration : IEntityTypeConfiguration<FireTruckAction>
    {
        public void Configure(EntityTypeBuilder<FireTruckAction> builder)
        {
            builder
                .HasKey(e => e.IdFireTruckAction);

            builder
                .Property(e => e.IdAction)
                .IsRequired();

            builder
                .Property(e => e.IdAction)
                .IsRequired();

            builder
                .Property(e => e.AssignmentDate)
                .IsRequired();
        }
    }
}
