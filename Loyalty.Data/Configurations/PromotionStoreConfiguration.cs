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
    public class PromotionStoreConfiguration : IEntityTypeConfiguration<PromotionStore>
    {
        public void Configure(EntityTypeBuilder<PromotionStore> builder)
        {
            builder.ToTable("PromotionStores");
            builder.HasKey(x => new { x.StoreId, x.PromotionId });

            builder.HasOne(x => x.Promotion).WithMany(x => x.PromotionStores).HasForeignKey(x => x.PromotionId);
            builder.HasOne(x => x.Store).WithMany(x => x.PromotionStores).HasForeignKey(x => x.StoreId);
        }
    }
}