using GestaoComprasVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoComprasVendas.Context.Config
{
    public class PurchaseItemsDbConfig : IEntityTypeConfiguration<PurchaseItems>
    {
        public void Configure(EntityTypeBuilder<PurchaseItems> builder)
        {
            builder.ToTable("PurchaseItems");
            builder.HasKey(x => x.PurchaseItemsId);
            builder.Property(p => p.Quantity).IsRequired();

            builder.HasOne(x => x.Product)
                .WithMany(product => product.PurchaseItems)
                .HasForeignKey(x => x.ProductId)
                .IsRequired();

            builder.HasOne(x => x.Purchase)
                .WithMany(purchase => purchase.PurchaseItems)
                .HasForeignKey(x => x.PurchaseId)
                .IsRequired();
        }
    }
}
