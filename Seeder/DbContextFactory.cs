using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using TP4_Ajax.Data;

namespace TP4_Ajax.Seeder
{
    public class DbContextFactory  // : IDesignTimeDbContextFactory<Exercice3_ModeleEFCoreDBContext>
    {
        public static TPDbContext CreateDbContext()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<TPDbContext>();
            var connectionString = configuration.GetConnectionString("MyConnection");
            builder.UseSqlServer(connectionString);

            return new TPDbContext(builder.Options);
        }
    }
}
