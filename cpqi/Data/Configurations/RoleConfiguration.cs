using cpqi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cpqi.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");

            builder.HasKey(r => r.RoleID);

            builder.Property(r => r.RoleName).IsRequired().HasMaxLength(100);
            builder.Property(r => r.Description).HasMaxLength(500);

            builder.HasData(
                new Role { RoleID = 1, RoleName = "Administrador", Description = "Usuário com acesso total ao sistema" },
                new Role { RoleID = 2, RoleName = "Professor", Description = "Usuário com permissões de professor" },
                new Role { RoleID = 3, RoleName = "Assistente administrativo", Description = "Usuário responsável por tarefas administrativas" }
            );
        }
    }
}