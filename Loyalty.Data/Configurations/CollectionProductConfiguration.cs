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
    public class CollectionProductConfiguration : IEntityTypeConfiguration<CollectionProduct>
    {
        public void Configure(EntityTypeBuilder<CollectionProduct> builder)
        {
            builder.ToTable("CollectionProducts");
            builder.HasKey(t => new { t.CollectionId, t.ProductId });

            builder.HasOne(t => t.Product).WithMany(pc => pc.CollectionProducts)
                .HasForeignKey(pc => pc.ProductId);

            builder.HasOne(t => t.Collection).WithMany(pc => pc.CollectionProducts)
              .HasForeignKey(pc => pc.CollectionId);
        }
    }
}