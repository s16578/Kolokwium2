using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Configuration
{
    public class FirefighterActionEfConfiguration : IEntityTypeConfiguration<FirefighterAction>
    {
        public void Configure(EntityTypeBuilder<FirefighterAction> builder)
        {
            builder
                .HasKey(e => new
                {
                    e.IdAction,
                    e.IdFirefighter
                });
        }
    }
}
