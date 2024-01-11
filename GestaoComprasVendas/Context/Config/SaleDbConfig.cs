using GestaoComprasVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoComprasVendas.Context.Config
{
    public class SaleDbConfig : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.RegistryDate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();

            builder.HasOne(x => x.Client)
                .WithMany(x => x.Sales)
                .HasForeignKey(x => x.ClientId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
