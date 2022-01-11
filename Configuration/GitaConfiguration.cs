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
    internal class GitaConfiguration:IEntityTypeConfiguration<Gita>
    {
        public void Configure(EntityTypeBuilder<Gita> builder)
        {
            //entità Gita
            builder.ToTable("Gita");
            builder.HasKey(g=>g.GitaID);
            builder.Property(g=>g.GitaID)
                   .HasColumnName("ID Gita")
                   .HasColumnOrder(0)
                   .IsRequired();
            builder.Property(g => g.DataPartenza)
                   .HasColumnOrder(1)
                   .HasColumnName("Data Partenza")
                   .IsRequired();


            //relazione gita e responsabile è di 1:n
            builder.HasOne(r => r.Responsabile)
                   .WithMany(g => g.Gite)
                   .HasForeignKey(f => f.ResponsabileID)
                   .HasConstraintName("FK_Responsabile");

            //relazione gita itinerario è 1:n
            builder.HasOne(i => i.Itinerario)
                   .WithMany(g => g.Gite)
                   .HasForeignKey(i => i.ItinerarioID);

            //relazione partecipante gita è molti a molti

            builder.HasMany(p => p.Partecipanti)
                   .WithMany(g => g.Gite);


            builder.HasData(

                new Gita
                {
                    ItinerarioID = 1,
                    ResponsabileID = 1,
                    DataPartenza = new DateTime(2022, 10, 23)

                });

            builder.HasData(
            new Gita
            {
                ItinerarioID = 2,
                ResponsabileID = 2,
                DataPartenza = new DateTime(2022, 8, 25)

            });

            builder.HasData(

            new Gita
            {
                ItinerarioID = 3,
                ResponsabileID = 1,
                DataPartenza = new DateTime(2022, 10, 28)

            });


        }

       

       
    }
}
