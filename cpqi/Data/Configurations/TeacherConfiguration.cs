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
    public class TeacherConfiguration: IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher");

            builder.HasKey(t => t.TeacherID);
            builder.Property(t => t.UserID).IsRequired();
            builder.Property(t => t.DisciplineID).IsRequired();
            builder.Property(t => t.PeriodID).IsRequired();
            builder.Property(t => t.TurmaID).IsRequired();

            // Relationships (foreign keys)
            builder.HasOne(t => t.User)
                   .WithMany()
                   .HasForeignKey(t => t.UserID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Discipline)
                   .WithMany()
                   .HasForeignKey(t => t.DisciplineID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Period)
                   .WithMany()
                   .HasForeignKey(t => t.PeriodID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Turma)
                   .WithMany()
                   .HasForeignKey(t => t.TurmaID)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
