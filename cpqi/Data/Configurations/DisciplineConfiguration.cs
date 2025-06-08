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
    public class DisciplineConfiguration:IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.ToTable("Discipline");
            builder.HasKey(d => d.DisciplineID);
            builder.Property(d => d.DisciplineName).IsRequired().HasMaxLength(50);
            builder.Property(d => d.DisciplineCode).IsRequired().HasMaxLength(10);
            // Seed data
            builder.HasData(
                new Discipline { DisciplineID = 1, DisciplineName = "Matemática", DisciplineCode = "MAT" },
                new Discipline { DisciplineID = 2, DisciplineName = "História", DisciplineCode = "HIS" },
                new Discipline { DisciplineID = 3, DisciplineName = "Geografia", DisciplineCode = "GEO" },
                new Discipline { DisciplineID = 4, DisciplineName = "Estudo Do Meio", DisciplineCode = "EM" },
                new Discipline { DisciplineID = 5, DisciplineName = "Educação Musical", DisciplineCode = "MUS" },
                new Discipline { DisciplineID = 6, DisciplineName = "Ciência Da Natureza", DisciplineCode = "CN" },
                new Discipline { DisciplineID = 7, DisciplineName = "Educação Manual E Plástica", DisciplineCode = "EMP" },
                new Discipline { DisciplineID = 8, DisciplineName = "Língua Portuguesa", DisciplineCode = "LP" },
                new Discipline { DisciplineID = 9, DisciplineName = "Língua Inglesa", DisciplineCode = "LI" },
                new Discipline { DisciplineID = 10, DisciplineName = "Língua Francesa", DisciplineCode = "LF" },
                new Discipline { DisciplineID = 11, DisciplineName = "Língua Kikongo", DisciplineCode = "LKIK" },
                new Discipline { DisciplineID = 12, DisciplineName = "Língua Umbundo", DisciplineCode = "LUMB" },
                new Discipline { DisciplineID = 13, DisciplineName = "Língua Kimbundo", DisciplineCode = "LKIM" }
            );
        }
    }
}
