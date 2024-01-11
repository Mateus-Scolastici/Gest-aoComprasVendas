using GestaoComprasVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoComprasVendas.Context.Config
{
    public class SupplierDbConfig : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Suppliers");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.PostalCode).HasColumnType("VARCHAR(8)").IsRequired();
            builder.Property(p => p.Phone).HasColumnType("VARHCHAR(11)").IsRequired();
        }
    }
}
