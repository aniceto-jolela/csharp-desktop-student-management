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
    public class InscricaoConfiguration: IEntityTypeConfiguration<Inscricao>
    {
        public void Configure(EntityTypeBuilder<Inscricao> builder)
        {
            builder.ToTable("Inscricao");
            builder.HasKey(i => i.InscricaoID);
            builder.HasIndex(i => i.FullName).IsUnique();
            builder.Property(i => i.InscricaoNumber).IsUnicode().IsRequired();
            builder.Property(i => i.FullName).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Phone1).IsRequired().HasMaxLength(20);
            builder.Property(i => i.Phone2).HasMaxLength(20);
            builder.Property(i => i.EncarregadoDeEducacao).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Status).HasConversion<string>().IsRequired().HasMaxLength(20);
            builder.Property(i => i.IsActive).IsRequired();
            builder.Property(i => i.IsStudent).IsRequired();
            builder.Property(i => i.CreatedBy).IsRequired().HasMaxLength(100);
            builder.Property(i => i.UpdatedBy).HasMaxLength(100);
            // Relationships
            builder.HasOne(i => i.Classe)
                   .WithMany()
                   .HasForeignKey(i => i.ClasseID)
                   .OnDelete(DeleteBehavior.Restrict); // Restrict delete to prevent deletion of Classe if there are Inscricao records associated

            builder.HasOne(i => i.Period)
                   .WithMany()
                   .HasForeignKey(i => i.PeriodID)
                   .OnDelete(DeleteBehavior.Restrict); // Prevent deletion of Period if there are Inscricao records associated
        }
    }
}
