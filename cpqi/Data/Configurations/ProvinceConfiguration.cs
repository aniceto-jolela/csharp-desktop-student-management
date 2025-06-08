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
    public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable("Province");
            builder.HasKey(p => p.ProvinceID);
            builder.Property(p => p.ProvinceName).IsRequired().HasMaxLength(200);
            // Seed data
            builder.HasData(
                new Province { ProvinceID = 1, ProvinceName = "Província de Luanda, com capital na Ingombota" },
                new Province { ProvinceID = 2, ProvinceName = "Província de Cabinda, com capital em Cabinda" },
                new Province { ProvinceID = 3, ProvinceName = "Província do Zaire, com capital em Mbanza Kongo" },
                new Province { ProvinceID = 4, ProvinceName = "Província do Uíge, com capital no Uíge" },
                new Province { ProvinceID = 5, ProvinceName = "Província do Bengo, com capital no Dande" },
                new Province { ProvinceID = 6, ProvinceName = "Província do Icolo e Bengo, com capital em Catete" },
                new Province { ProvinceID = 7, ProvinceName = "Província do Cuanza - Norte, com capital no Cazengo" },
                new Province { ProvinceID = 8, ProvinceName = "Província do Cuanza - Sul, com capital no Sumbe" },
                new Province { ProvinceID = 9, ProvinceName = "Província de Malanje, com capital em Malanje" },
                new Province { ProvinceID = 10, ProvinceName = "Província da Lunda - Norte, com capital no Dundo" },
                new Province { ProvinceID = 11, ProvinceName = "Província da Lunda - Sul, com capital em Saurimo" },
                new Province { ProvinceID = 12, ProvinceName = "Província do Moxico, com capital no Luena" },
                new Province { ProvinceID = 13, ProvinceName = "Província do Moxico Leste, com capital no Cazombo" },
                new Province { ProvinceID = 14, ProvinceName = "Província do Bié, com capital no Cuito" },
                new Province { ProvinceID = 15, ProvinceName = "Província do Huambo, com capital no Huambo" },
                new Province { ProvinceID = 16, ProvinceName = "Província de Benguela, com capital em Benguela" },
                new Province { ProvinceID = 17, ProvinceName = "Província do Namibe, com capital em Moçâmedes" },
                new Province { ProvinceID = 18, ProvinceName = "Província da Huíla, com capital no Lubango" },
                new Province { ProvinceID = 19, ProvinceName = "Província do Cunene, com capital no Cuanhama" },
                new Province { ProvinceID = 20, ProvinceName = "Província do Cubango, com capital em Menongue" },
                new Province { ProvinceID = 21, ProvinceName = "Província do Cuando, com capital em Mavinga" }
            );

        }
    }
}
