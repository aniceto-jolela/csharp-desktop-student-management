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
    public class ClasseConfiguration:IEntityTypeConfiguration<Classe>
    {
        public void Configure(EntityTypeBuilder<Classe> builder)
        {
            builder.ToTable("Classe");
            builder.HasKey(c => c.ClasseID);
            builder.Property(c => c.ClasseName).IsRequired().HasMaxLength(15);
            // Seed data
            builder.HasData(
                new Classe { ClasseID = 1, ClasseName = "Iniciação"},
                new Classe { ClasseID = 2, ClasseName = "1ª Classe"},
                new Classe { ClasseID = 3, ClasseName = "2ª Classe"},
                new Classe { ClasseID = 4, ClasseName = "3ª Classe"},
                new Classe { ClasseID = 5, ClasseName = "4ª Classe"},
                new Classe { ClasseID = 6, ClasseName = "5ª Classe"},
                new Classe { ClasseID = 7, ClasseName = "6ª Classe"},
                new Classe { ClasseID = 8, ClasseName = "Todas Classes" }
            );
        }
    }
}
