using AgenziaGite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaGite.Configuration
{
    internal class ItinerarioConfiguration:IEntityTypeConfiguration<Itinerario>
    {
        public void Configure(EntityTypeBuilder<Itinerario> builder)
        {
            builder.ToTable("Itinerario");
            builder.HasKey(i => i.ItinerarioID);
            builder.Property(i=>i.Description).IsRequired();
            builder.Property(i=>i.Price).IsRequired();
            builder.Property(i=>i.Durata).IsRequired(); 

            //relazione

            builder.HasMany(g => g.Gite)
                   .WithOne(g => g.Itinerario)
                   .HasForeignKey(g => g.ItinerarioID);

            builder.HasData(
                new Itinerario
                {
                    Description = "Gita Notte sulle Dolomiti",
                    Price = 323,
                    Durata = "Una notte"

                },

            new Itinerario
            {
                Description = "Sotto la torre Eiffel",
                Price = 323,
                Durata = "Due Notti"

            },

            new Itinerario
            {
                Description = "Coming to London",
                Price = 800,
                Durata = "Tre notti"

            });
        }


    }
}
