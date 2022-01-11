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
    internal class PartecipanteConfiguration : IEntityTypeConfiguration<Partecipante>
    {
        public void Configure(EntityTypeBuilder<Partecipante> builder)
        {
            //Entità Partecipante
            builder.ToTable("Partecipante");
            builder.HasKey(p => p.PartecipanteID);
            builder.Property(p => p.PartecipanteID)
                .HasColumnOrder(0)
                .HasColumnName("Partecipante ID");
            builder.Property(p => p.Name)
                .HasColumnName("Name")
                .HasMaxLength(30)
                .IsRequired();
            builder.Property(p => p.Surname)
               .HasColumnName("Surname")
               .HasMaxLength(30)
               .IsRequired();
            builder.Property(p => p.BirthDate)
               .HasColumnName("Data di Nascita")
               .HasColumnType("DateTime")
               .IsRequired();
            builder.Property(p => p.City)
               .HasColumnName("Città")
               .HasMaxLength(30)
               .IsRequired();
            builder.Property(p => p.Address)
               .HasColumnName("Indirizzo")
               .HasMaxLength(30)
               .IsRequired();


            builder.HasMany(g => g.Gite)
                   .WithMany(p => p.Partecipanti);


        }
    }
}
