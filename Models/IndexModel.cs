using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTraining.Models
{
    public class IndexModel
    {
        public string IndexTitle { get; set; }
        //@@TODO ogarnąć EventHandler do pobierania zdjęcia z bazy danych Entity Framework Core

        //public string IndexImage { get; set; }
        public string IndexDescription { get; set; }
        public string IndexStreamInformation { get; set; }
    }
}
