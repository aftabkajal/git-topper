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
        public DbSet<Repositories> Repositories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Repositories>()
                .HasOne<Owner>(own => own.Owner)
                .WithMany(repos => repos.Repositories)
                .IsRequired();

        }


    }
}
