using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab_2.Models
{
    public class BusinesContext : DbContext
    {
        public BusinesContext(DbContextOptions<BusinesContext> options)
            : base(options)
        {
        }

        public DbSet<Businessmen> Businessmens { get; set; }
        public DbSet<Company> Companys { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bussnes>()
                .HasKey(t => new { t.IdBusnesmen, t.IdCompany });

            modelBuilder.Entity<Bussnes>()
             

            modelBuilder.Entity<Bussnes>()
                
        }
    }
}
