using AgenziaGite.Configuration;
using AgenziaGite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaGite
{
    internal class AgenziaGiteContext : DbContext
    {
        public DbSet<Gita> Gite { get; set; }
        public DbSet<Partecipante> Partecipanti { get; set; }

        public DbSet<Responsabile> Responsabile { get; set; }

        public DbSet<Itinerario> Itinerari { get; set; }

        public AgenziaGiteContext()
        {

        }

        public AgenziaGiteContext(DbContextOptions<AgenziaGiteContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgenziaViaggi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Gita>(new GitaConfiguration());
            modelBuilder.ApplyConfiguration<Itinerario>(new ItinerarioConfiguration());
            modelBuilder.ApplyConfiguration<Responsabile>(new ResponsabileConfiguration());
            modelBuilder.ApplyConfiguration<Partecipante>(new PartecipanteConfiguration());

            
        }
    }
}
