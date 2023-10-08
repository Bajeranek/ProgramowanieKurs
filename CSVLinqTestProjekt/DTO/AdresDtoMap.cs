using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVLinqTestProjekt.DTO
{
    public class AdresDtoMap : ClassMap<AdresDto>
    {
        public AdresDtoMap()
        {
            Map(m=> m.Id).Name(nameof(AdresDto.Id));
            Map(m=> m.Ulica).Name(nameof(AdresDto.Ulica));
            Map(m=> m.Numer).Name(nameof(AdresDto.Numer));
            Map(m => m.IdOsoby).Name(nameof(AdresDto.IdOsoby));
        }
    }
}
