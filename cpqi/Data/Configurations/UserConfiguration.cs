using cpqi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cpqi.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.UserID);

            builder.HasIndex(u => u.UserName).IsUnique();
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.UserName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.FullName).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Sex).IsRequired().HasMaxLength(10);
            builder.Property(u => u.Bi).IsRequired().HasMaxLength(14);
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.Phone).HasMaxLength(20);
            builder.Property(u => u.PhotoPath).HasMaxLength(500);
            builder.Property(u => u.FileBiPath).HasMaxLength(500);
            builder.Property(u => u.FileCvPath).HasMaxLength(500);
            builder.Property(u => u.CreatedBy).HasMaxLength(100);
            builder.Property(u => u.UpdatedBy).HasMaxLength(100);

            builder.HasOne(u => u.Role)
                   .WithMany()
                   .HasForeignKey(u => u.RoleID)
                   .OnDelete(DeleteBehavior.Restrict);

            // Seeding
            builder.HasData(
                new User
                {
                    UserID = 1,
                    UserName = "admin",
                    FullName = "System Administrator",
                    Sex = "MASCULINO",
                    Email = "otecina500@gmail.com",
                    Phone = "+244935259317",
                    Bi = "00000000000000",
                    PasswordHash = [166, 130, 25, 219, 239, 119, 31, 83, 197, 26, 127, 199, 94, 90, 121, 125, 183, 232, 233, 196, 174, 70, 74, 131, 184, 31, 255, 36, 182, 63, 74, 71],
                    Salt = [86, 20, 249, 233, 128, 57, 165, 36, 73, 217, 227, 12, 119, 2, 122, 144],
                    PhotoPath = null,
                    DateOfBirth = new DateTime(1999, 2, 8),
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
                    PasswordHash = [42, 235, 23, 255, 103, 86, 59, 191, 154, 249, 178, 252, 139, 211, 7, 40, 28, 153, 9, 102, 68, 141, 147, 247, 194, 237, 188, 99, 185, 184, 155, 115],
                    Salt = [42, 235, 128, 224, 239, 144, 83, 41, 139, 254, 244, 34, 237, 152, 246, 15],
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