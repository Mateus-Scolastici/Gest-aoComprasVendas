using GestaoComprasVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoComprasVendas.Context.Config
{
    public class ProductDbConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).HasColumnType("VARCHAR(30)").IsRequired();
            builder.Property(p => p.Price).IsRequired();
        }
    }
}
