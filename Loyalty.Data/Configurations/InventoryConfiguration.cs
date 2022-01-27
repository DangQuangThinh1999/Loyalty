using Loyalty.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Configurations
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("Inventories");
            builder.HasKey(x => new { x.ProductId, x.Id });
            builder.Property(x => x.Diachi).HasMaxLength(200);
            builder.Property(x => x.sku).HasMaxLength(20);
            builder.Property(x => x.TotalTon).IsRequired();

            builder.HasOne(x => x.Product).WithMany(x => x.Inventories).HasForeignKey(x => x.ProductId);
        }
    }
}