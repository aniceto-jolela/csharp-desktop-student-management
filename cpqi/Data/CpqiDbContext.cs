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
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserID=1,
                    UserName="admin",
                    FullName= "System Administrator",
                    Sex="MASCULINO",
                    Email="otecina500@gmail.com",
                    Phone="+244935259317",
                    Bi= "00000000000000",
                    PasswordHash = [ 166, 130, 25, 219, 239, 119, 31, 83, 197, 26, 127, 199, 94, 90, 121, 125, 183, 232, 233, 196, 174, 70, 74, 131, 184, 31, 255, 36, 182, 63, 74, 71 ],
                    Salt = [ 86, 20, 249, 233, 128, 57, 165, 36, 73, 217, 227, 12, 119, 2, 122, 144 ],
                    PhotoPath=null,
                    DateOfBirth=new DateTime(1999,2,8),
                    IsStaff = true,
                    IsActive = true,
                    IsSuperUser = true,
                    DateJoined = new DateTime(2025,5,27),
                    FileBiPath = null,
                    IssuedOn = new DateTime(2020, 1, 1),
                    ValidUntil = new DateTime(2030, 1, 1),
                    FileCvPath = null,
                    RoleID = 1,
                    CreatedAt = new DateTime(2025,5,27),
                    CreatedBy = "seed",
                    UpdatedAt = null,
                    UpdatedBy = null
                },
                new User
                {
                    UserID = 2,
                    UserName = "admin12345678",
                    FullName = "Administrador Padrão",
                    Sex = "MASCULINO",
                    Email = "admin@cpqi.com",
                    Phone = "111111111",
                    Bi = "11111111111111",
                    PasswordHash = [ 42, 235, 23, 255, 103, 86, 59, 191, 154, 249, 178, 252, 139, 211, 7, 40, 28, 153, 9, 102, 68, 141, 147, 247, 194, 237, 188, 99, 185, 184, 155, 115 ],
                    Salt =[ 42, 235, 128, 224, 239, 144, 83, 41, 139, 254, 244, 34, 237, 152, 246, 15 ],
                    PhotoPath = null,
                    DateOfBirth = new DateTime(1992, 1, 1),
                    IsStaff = true,
                    IsActive = true,
                    IsSuperUser = true,
                    DateJoined = new DateTime(2025, 5, 27),
                    FileBiPath = null,
                    IssuedOn = new DateTime(2020, 1, 1),
                    ValidUntil = new DateTime(2030, 1, 1),
                    FileCvPath = null,
                    RoleID = 1,
                    CreatedAt = new DateTime(2025, 5, 27),
                    CreatedBy = "seed",
                    UpdatedAt = null,
                    UpdatedBy = null
                }
                );
        }
    }
}
