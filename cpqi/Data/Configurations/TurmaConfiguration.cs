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
    public class TurmaConfiguration:IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("Turma");
            builder.HasKey(t => t.TurmaID);
            builder.Property(t => t.NameTurma).IsRequired().HasMaxLength(15);
            builder.Property(t => t.ClassRoomID).IsRequired();
            builder.Property(t => t.ClasseID).IsRequired();
            builder.Property(t => t.MainTeacher).HasMaxLength(100); // Optional field for main teacher's name
            // Relationships
            builder.HasOne(t => t.ClassRoom)
                   .WithMany(crm => crm.Turmas)
                   .HasForeignKey(t => t.ClassRoomID)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Classe)
                   .WithMany(c=>c.Turmas)
                   .HasForeignKey(t => t.ClasseID)
                   .OnDelete(DeleteBehavior.Restrict);
            // Seed data
            builder.HasData(
                new Turma { TurmaID = 1, NameTurma = "Turma A", ClassRoomID = 1, ClasseID = 1 },
                new Turma { TurmaID = 2, NameTurma = "Turma B", ClassRoomID = 2, ClasseID = 2 },
                new Turma { TurmaID = 3, NameTurma = "Turma C", ClassRoomID = 3, ClasseID = 3 },
                new Turma { TurmaID = 4, NameTurma = "Turma D", ClassRoomID = 4, ClasseID = 4 },
                new Turma { TurmaID = 5, NameTurma = "Turma E", ClassRoomID = 5, ClasseID = 5 },
                new Turma { TurmaID = 6, NameTurma = "Turma F", ClassRoomID = 6, ClasseID = 6 },
                new Turma { TurmaID = 7, NameTurma = "Turma G", ClassRoomID = 7, ClasseID = 7 }
            );

        }
    }
}
