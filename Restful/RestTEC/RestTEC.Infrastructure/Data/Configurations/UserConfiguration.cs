using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestTEC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestTEC.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User> 
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasNoKey();

            builder.ToTable("User");

            builder.Property(e => e.Access)
                .IsRequired()
                .HasColumnName("Access")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasColumnName("Password")
                .HasMaxLength(100)
                .IsUnicode(false);

        }
    }
}
