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
    public class ClassRoomConfiguration: IEntityTypeConfiguration<ClassRoom>
    {
        public void Configure(EntityTypeBuilder<ClassRoom> builder)
        {
            builder.ToTable("ClassRoom");
            builder.HasKey(cr => cr.ClassRoomID);
            builder.Property(cr => cr.ClassRoomNumber).IsRequired().HasMaxLength(15);
            builder.Property(cr => cr.MaximumCapacity).IsRequired();
            builder.Property(cr => cr.Location).IsRequired().HasMaxLength(30);
            // Seed data
            builder.HasData(
                new ClassRoom { ClassRoomID = 1, ClassRoomNumber = "Sala 01", MaximumCapacity = 30, Location = "Rés-do-chão" },
                new ClassRoom { ClassRoomID = 2, ClassRoomNumber = "Sala 02", MaximumCapacity = 30, Location = "1º Andar" },
                new ClassRoom { ClassRoomID = 3, ClassRoomNumber = "Sala 03", MaximumCapacity = 30, Location = "1º Andar" },
                new ClassRoom { ClassRoomID = 4, ClassRoomNumber = "Sala 04", MaximumCapacity = 30, Location = "1º Andar" },
                new ClassRoom { ClassRoomID = 5, ClassRoomNumber = "Sala 05", MaximumCapacity = 30, Location = "1º Andar" },
                new ClassRoom { ClassRoomID = 6, ClassRoomNumber = "Sala 06", MaximumCapacity = 30, Location = "1º Andar" },
                new ClassRoom { ClassRoomID = 7, ClassRoomNumber = "Sala 07", MaximumCapacity = 30, Location = "1º Andar" },
                new ClassRoom { ClassRoomID = 8, ClassRoomNumber = "Todas as Salas", MaximumCapacity = 210, Location = "Todos Andares" }
            );
        }
    }
}
