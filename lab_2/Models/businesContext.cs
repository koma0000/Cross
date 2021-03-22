using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab_2.Models
{
    public class businesContext : DbContext
    { 
        public businesContext(DbContextOptions<businesContext> options)
            : base(options)
        {

        }

        public DbSet<Businessmen> businessmens { get; set; }
        public DbSet<Company> companies { get; set; }



         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Busines>()
                .HasKey(t => new { t.BusinessmenId, t.CompanyId });

            modelBuilder.Entity<Busines>()
                .HasOne(sc => sc.Businessmen)
                .WithMany(s => s.business)
                .HasForeignKey(sc => sc.BusinessmenId);

            modelBuilder.Entity<Busines>()
                .HasOne(sc => sc.Companys)
                .WithMany(c => c.comm)
                .HasForeignKey(sc => sc.CompanyId);
        }
    }
}
