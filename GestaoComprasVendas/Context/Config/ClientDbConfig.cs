using GestaoComprasVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoComprasVendas.Context.Config
{
    public class ClientDbConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.PostalCode).HasColumnType("VARCHAR(8)").IsRequired();
            builder.Property(p => p.Phone).HasColumnType("VARCHAR(11)").IsRequired();
        }
    }
}
