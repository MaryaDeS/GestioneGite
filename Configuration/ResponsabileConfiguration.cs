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
    internal class ResponsabileConfiguration : IEntityTypeConfiguration<Responsabile>
    {
        public void Configure(EntityTypeBuilder<Responsabile> builder)
        {
            //Entità Responsabile Gita
            builder.ToTable("Responsabile");
            builder.HasKey(r=> r.ResponsabileID);
            builder.Property(r => r.ResponsabileID)
                   .HasColumnName("ID Responsabile")
                   .HasColumnOrder(0);

            builder.Property(r => r.Name)
                   .HasColumnName("Name")
                   .HasColumnOrder(1)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(r => r.Surname)
                   .HasColumnName("Surname")
                   .HasColumnOrder(1)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(r => r.TelephoneNumber)
                   .HasColumnName("Telephone Number")
                   .IsFixedLength()
                   .HasMaxLength(10)
                   .IsRequired();



            //Relazione Responsabile Gita ==> 1:n

            builder.HasMany(g => g.Gite)
                   .WithOne(g => g.Responsabile)
                   .HasForeignKey(g => g.ResponsabileID);

           

        }
    }
}
