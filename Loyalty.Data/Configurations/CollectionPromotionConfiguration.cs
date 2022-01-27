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
    public class CollectionPromotionConfiguration : IEntityTypeConfiguration<CollectionPromotion>
    {
        public void Configure(EntityTypeBuilder<CollectionPromotion> builder)
        {
            builder.ToTable("CollectionPromotions");
            builder.HasKey(t => new { t.CollectionId, t.PromotionId });

            builder.HasOne(t => t.Promotion).WithMany(pc => pc.CollectionPromotions)
                .HasForeignKey(pc => pc.PromotionId);

            builder.HasOne(t => t.Collection).WithMany(pc => pc.CollectionPromotions)
              .HasForeignKey(pc => pc.CollectionId);
        }
    }
}