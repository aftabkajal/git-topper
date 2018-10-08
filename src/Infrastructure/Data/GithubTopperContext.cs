using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
   public class GithubTopperContext : DbContext
    {
        public GithubTopperContext(DbContextOptions<GithubTopperContext> options) : base(options){ }

        public DbSet<Owner> Owner { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Repositories> Repositories { get; set; }
        public DbSet<License> License { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Repositories>()
                .HasOne<Owner>(own => own.Owner)
                .WithMany(repos => repos.Repositories)
                .IsRequired();

            modelBuilder.Entity<License>()
                .HasOne<Repositories>(repos => repos.Repositories)
                .WithOne(lic => lic.License);

            modelBuilder.Entity<Permissions>()
                .HasOne<Repositories>(repos => repos.Repositories)
                .WithOne(per => per.Permissions);

        }


    }
}
