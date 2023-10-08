using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVLinqTestProjekt.DTO
{
    public class ImieNazwiskoDtoMap : ClassMap<ImieNazwiskoDto>
    {
        public ImieNazwiskoDtoMap()
        {
            Map(m => m.Id).Name(nameof(ImieNazwiskoDto.Id));
            Map(m=> m.Imie).Name(nameof(ImieNazwiskoDto.Imie));
            Map(m=> m.Nazwisko).Name(nameof(ImieNazwiskoDto.Nazwisko));

        }
    }
}
