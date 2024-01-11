using GestaoComprasVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoComprasVendas.Context.Config
{
    public class SaleItemsDbConfig : IEntityTypeConfiguration<SaleItems>
    {
        public void Configure(EntityTypeBuilder<SaleItems> builder)
        {
            builder.ToTable("SaleItems");
            builder.HasKey(x => x.SaleItemsId);
            builder.Property(p => p.Quantity).IsRequired();

            builder.HasOne(x => x.Product)
                    .WithMany(product => product.SaleItems)
                    .HasForeignKey(x => x.ProductId)
                    .IsRequired();

            builder.HasOne(x => x.Sale)
                .WithMany(purchase => purchase.SaleItems)
                .HasForeignKey(x => x.SaleId)
                .IsRequired();
        }
    }
}
