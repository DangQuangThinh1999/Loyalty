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
    public class PromotionProductConfiguration : IEntityTypeConfiguration<PromotionProduct>
    {
        public void Configure(EntityTypeBuilder<PromotionProduct> builder)
        {
            builder.ToTable("PromotionProducts");
            builder.HasKey(x => new { x.ProductId, x.PromotionId });

            builder.Property(x => x.total).IsRequired().HasMaxLength(200);

            builder.HasOne(x => x.Product).WithMany(x => x.PromotionProducts).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Promotion).WithMany(x => x.PromotionProducts).HasForeignKey(x => x.PromotionId);
        }
    }
}