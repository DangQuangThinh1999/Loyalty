using Loyalty.Data.Entities;
using Loyalty.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.name).HasMaxLength(200);
            builder.Property(x => x.sku).HasMaxLength(20);
            builder.Property(x => x.stock).IsRequired();
            builder.Property(x => x.market).HasMaxLength(20);
            builder.Property(x => x.descripition).HasMaxLength(300);
            builder.Property(x => x.size).HasMaxLength(10);
            builder.Property(x => x.trongluong).HasMaxLength(10);
            builder.Property(x => x.unit).HasMaxLength(20);
            builder.Property(x => x.price).IsRequired();
        }
    }
}