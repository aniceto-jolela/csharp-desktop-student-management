using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cpqi.Models;
using cpqi.Data.Configurations;

namespace cpqi.Data
{
    public class CpqiDbContext: DbContext
    {
        public CpqiDbContext(DbContextOptions<CpqiDbContext> options) : base(options){}
        public CpqiDbContext() { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
