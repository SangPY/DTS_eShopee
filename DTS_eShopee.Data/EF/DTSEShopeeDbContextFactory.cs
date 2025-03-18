using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DTS_eShopee.Data.EF
{
    public class DTSEShopeeDbContextFactory : IDesignTimeDbContextFactory<DTSEShopeeDbContext>
    {
        public DTSEShopeeDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DTS_eShopeeDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<DTSEShopeeDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new DTSEShopeeDbContext(optionsBuilder.Options);
        }
    }
}