using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TP4_Ajax.Models;

namespace TP4_Ajax.Data
{
    public class TPDbContext : DbContext
    {
        public TPDbContext (DbContextOptions<TPDbContext> options)
            : base(options) { }


        public DbSet<TP4_Ajax.Models.Client> Clients { get; set; }
        public DbSet<TP4_Ajax.Models.Abonnement> Abonnements { get; set; }

        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Abonnement> abonnements = new List<Abonnement>()
            {
            new Abonnement(){ AbonnementId=1, Type="Regulier", PrixMensuel=0, RabaisPourcentage=0},
            new Abonnement(){ AbonnementId=2, Type="Argent", PrixMensuel=50, RabaisPourcentage=10},
            new Abonnement(){ AbonnementId=3, Type="Or", PrixMensuel=100, RabaisPourcentage=15}
            };
            modelBuilder.Entity<Abonnement>().HasData(abonnements);
        }
    }
}
