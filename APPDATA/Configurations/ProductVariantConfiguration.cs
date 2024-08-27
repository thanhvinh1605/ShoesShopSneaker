using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using APPDATA.Models;

namespace MCV.Configurations
{
    public class ProductVariantConfiguration : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.size).WithMany(c => c.productVariants).HasForeignKey(c => c.sizeId);
            builder.HasOne(c => c.color).WithMany(c => c.productVariants).HasForeignKey(c => c.colorId);
            //builder.HasOne(c => c.product).WithMany(c => c.productVariants).HasForeignKey(c => c.productId);
        }

    }
}