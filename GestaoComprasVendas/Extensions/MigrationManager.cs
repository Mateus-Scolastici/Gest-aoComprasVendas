using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Runtime.CompilerServices;

namespace GestaoComprasVendas.Extensions
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase<T>(this  IHost host) where T : DbContext, IDisposable
        {
            using(IServiceScope serviceScope = host.Services.CreateScope()) 
            {
                using T val = serviceScope.ServiceProvider.GetRequiredService<T>();
                val.Database.Migrate();
            }

            return host;
        }
    }
}
