using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RestTEC.Core.Entities;
using RestTEC.Infrastructure.Data.Configurations;

#nullable disable

namespace RestTEC.Infrastructure.Data
{
    public partial class RestTECContext : DbContext
    {
        public RestTECContext()
        {
        }

        public RestTECContext(DbContextOptions<RestTECContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new MenuConfiguration());

            modelBuilder.ApplyConfiguration(new UserConfiguration());

        
        }

    }
}
