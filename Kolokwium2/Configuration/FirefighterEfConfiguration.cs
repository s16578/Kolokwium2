using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Configuration
{
    public class FirefighterEfConfiguration : IEntityTypeConfiguration<Firefighter>
    {
        public void Configure(EntityTypeBuilder<Firefighter> builder)
        {
            builder
                .HasKey(e => e.IdFirefighter);

            builder
                .Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
