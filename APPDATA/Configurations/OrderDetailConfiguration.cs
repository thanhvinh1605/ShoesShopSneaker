using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using APPDATA.Models;

namespace MCV.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(c => c.Id);
            //builder.HasOne(c => c.order).WithMany(c => c.OrderDetail).HasForeignKey(c => c.OrderId);
            builder.HasOne(c => c.productVariant).WithMany(c => c.orderDetails).HasForeignKey(c => c.productId);
        }

    }
}