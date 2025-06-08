using cpqi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cpqi.Data.Configurations
{
    public class PeriodConfiguration: IEntityTypeConfiguration<Period>
    {
        public void Configure(EntityTypeBuilder<Period> builder)
        {
            builder.ToTable("Period");
            builder.HasKey(p => p.PeriodID);
            builder.Property(p => p.PeriodName).IsRequired().HasMaxLength(20);
            // Seed data
            builder.HasData(
                new Period { PeriodID = 1, PeriodName = "Manhã" },
                new Period { PeriodID = 2, PeriodName = "Tarde" },
                new Period { PeriodID = 3, PeriodName = "Manhã e Tarde" }
            );
        }
    }
}
