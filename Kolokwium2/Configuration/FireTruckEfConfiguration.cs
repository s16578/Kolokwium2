using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Configuration
{
    public class FireTruckEfConfiguration : IEntityTypeConfiguration<FireTruck>
    {
        public void Configure(EntityTypeBuilder<FireTruck> builder)
        {
            builder
                .HasKey(e => e.IdFireTruck);

            builder
                .Property(e => e.OperationalNumber)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(e => e.SpecialEquipment)
                .IsRequired();
        }
    }
}
