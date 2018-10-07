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

        public DbSet<User> Users { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Repositories> Repositories { get; set; }

    }
}
