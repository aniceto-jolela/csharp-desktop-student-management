using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace cpqi.Data
{
    public class CpqiDbContextFactory : IDesignTimeDbContextFactory<CpqiDbContext>
    {
        public CpqiDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<CpqiDbContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("CpqiDB"));

            return new CpqiDbContext(optionsBuilder.Options);
        }
    }
}
