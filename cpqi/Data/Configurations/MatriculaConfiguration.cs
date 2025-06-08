using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cpqi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cpqi.Data.Configurations
{
    public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.ToTable("Matricula");
            builder.HasKey(m => m.MatriculaID);
            builder.HasIndex(m => m.BiCedula).IsUnique().HasDatabaseName("IX_Matricula_BiCedula");
            builder.Property(m => m.MatriculaNumber).IsUnicode().IsRequired();
            builder.Property(m => m.FatherName).IsRequired().HasMaxLength(100);
            builder.Property(m => m.MotherName).IsRequired().HasMaxLength(100);
            builder.Property(m => m.DateOfBirth).IsRequired();
            builder.Property(m => m.NaturalOf).IsRequired().HasMaxLength(50);
            builder.Property(m => m.ResideEm).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Bairro).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Rua).IsRequired().HasMaxLength(50);
            builder.Property(m => m.HouseNumber).IsRequired().HasMaxLength(10);
            builder.Property(m => m.BiCedula).IsRequired().HasMaxLength(20);
            builder.Property(m => m.IssuedOn).IsRequired();
            builder.Property(m => m.ValidUntil).IsRequired();

            builder.Property(m => m.TransferidoOfSchool).HasMaxLength(100);
            builder.Property(m => m.LocalizadoEm).HasMaxLength(100);
            builder.Property(m => m.PhoneFather).HasMaxLength(20);
            builder.Property(m => m.PhoneMother).HasMaxLength(20);
            builder.Property(m => m.Patologia).IsRequired().HasMaxLength(10);
            builder.Property(m => m.IsUsingAnyMedication).IsRequired().HasMaxLength(10);
            builder.Property(m => m.CopyOfReceitaPath).HasMaxLength(500);
            builder.Property(m => m.PhotoPath).HasMaxLength(500);
            builder.Property(m => m.DateMatricula).IsRequired();
            builder.Property(m => m.Status).HasConversion<string>().IsRequired().HasMaxLength(20);
            builder.Property(m => m.IsActive).IsRequired();

            builder.Property(m => m.CreatedBy).IsRequired().HasMaxLength(100);
            builder.Property(m => m.UpdatedBy).HasMaxLength(100);

            // Relationships
            builder.HasOne(m => m.Inscricao)
                   .WithMany(i=> i.Matriculas)
                   .HasForeignKey(m => m.InscricaoID)
                   .OnDelete(DeleteBehavior.Cascade); // Cascade delete to remove Matricula when Inscricao is deleted

            builder.HasOne(m => m.Turma)
                   .WithMany()
                   .HasForeignKey(m => m.TurmaID)
                   .OnDelete(DeleteBehavior.Restrict); // Restrict delete to prevent deletion of Turma if there are Matricula records associated

            builder.HasOne(m => m.Province)
                   .WithMany()
                   .HasForeignKey(m => m.ProvinceID)
                   .OnDelete(DeleteBehavior.Restrict); // Prevent deletion of Province if there are Matricula records associated
        }
    }
}
