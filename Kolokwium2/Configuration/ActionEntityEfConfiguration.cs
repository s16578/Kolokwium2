using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Configuration
{
    public class ActionEntityEfConfiguration : IEntityTypeConfiguration<ActionEntity>
    {

        public void Configure(EntityTypeBuilder<ActionEntity> builder)
        {
            builder
                .HasKey(e => e.IdAction);

            builder
                .Property(e => e.StartTime)
                .IsRequired();

            builder
                .Property(e => e.NeedSpecialEquipment)
                .IsRequired();
        }
    }
}
