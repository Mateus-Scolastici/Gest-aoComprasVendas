using GestaoComprasVendas.Context;
using GestaoComprasVendas.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace GestaoComprasVendas
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            host.MigrateDatabase<OrganizatorContext>();

            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<FrmMain>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            return Host
                .CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContextPool<OrganizatorContext>(
                        o => o.UseSqlServer(connectionString)
                    );

                    services.AddTransient<FrmMain>();
                    services.AddTransient<FrmAddClient>();
                    services.AddTransient<FrmAddSupplier>();
                    services.AddTransient<FrmAddPurchase>();
                    services.AddTransient<FrmAddProduct>();
                    services.AddTransient<FrmAddSale>();
                    services.AddTransient<FrmSalesMinusPurchases>();
                });
        }
    }
}