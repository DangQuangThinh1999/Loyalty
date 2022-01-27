using Loyalty.Data.Entities;
using Loyalty.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Configurations
{
    public class CustomerStoreConfiguration : IEntityTypeConfiguration<CustomerStore>
    {
        public void Configure(EntityTypeBuilder<CustomerStore> builder)
        {
            builder.ToTable("CustomerStores");
            builder.HasKey(x => new { x.CustomerId, x.StoreId });
            builder.HasOne(t => t.Customer).WithMany(pc => pc.CustomerStores)
               .HasForeignKey(pc => pc.CustomerId);

            builder.HasOne(t => t.Store).WithMany(pc => pc.CustomerStores)
              .HasForeignKey(pc => pc.StoreId);
            builder.Property(x => x.status).HasDefaultValue(Status_Customer.waiting_for_deliver);
        }
    }
}