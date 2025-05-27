using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cpqi.Models;

namespace cpqi.Data
{
    public class CpqiDbContext: DbContext
    {
        public CpqiDbContext(DbContextOptions<CpqiDbContext> options) : base(options){}

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleID = 1, RoleName = "Administrador", Description = "Usuário com acesso total ao sistema" },
                new Role { RoleID = 2, RoleName = "Professor", Description = "Usuário com permissões de professor" },
                new Role { RoleID = 3, RoleName = "Assistente administrativa", Description = "Usuário responsável por tarefas administrativas" }
            );  
        }
    }
}
