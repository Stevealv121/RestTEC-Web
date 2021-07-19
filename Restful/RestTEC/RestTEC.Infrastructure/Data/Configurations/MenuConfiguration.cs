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
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            //builder.HasNoKey();

            builder.ToTable("Menu");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(e => e.Price)
                .HasColumnName("Price");

            builder.Property(e => e.Calories)
                .HasColumnName("Calories");
            
        }
    }
}
