using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVLinqTestProjekt.DTO
{
    public class AdresDto
    {


        public int Id { get; set; }

        public string Ulica { get; set; }

   
        public string Numer { get; set; }
   
        public int IdOsoby { get; set; }

    }
}
