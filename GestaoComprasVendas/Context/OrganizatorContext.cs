using GestaoComprasVendas.Context.Config;
using GestaoComprasVendas.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoComprasVendas.Context
{
    public class OrganizatorContext : DbContext
    {
        public OrganizatorContext(DbContextOptions<OrganizatorContext> options) : base(options) 
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PurchaseItems> ProductPurchases { get; set; }
        public DbSet<SaleItems> ProductSales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductDbConfig());
            modelBuilder.ApplyConfiguration(new PurchaseItemsDbConfig());
            modelBuilder.ApplyConfiguration(new SaleItemsDbConfig());
            modelBuilder.ApplyConfiguration(new ClientDbConfig());
            modelBuilder.ApplyConfiguration(new SaleDbConfig());
            modelBuilder.ApplyConfiguration(new PurchaseDbConfig());
        }
    }
}
