using GestaoComprasVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoComprasVendas.Context.Config
{
    public class PurchaseDbConfig : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("Purchases");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.RegistryDate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();

            builder.HasOne(x => x.Supplier)
                .WithMany(x => x.Purchases)
                .HasForeignKey(x => x.SupplierId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
