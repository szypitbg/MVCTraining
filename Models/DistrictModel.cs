using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTraining.Models
{
    public class DistrictModel
    {
        public string DistrictItemNumber { get; set; }
        //@@TODO ogarnąć EventHandler do pobierania zdjęcia z bazy danych Entity Framework Core

        //public string DistrictImage { get; set; }
        public string DistrictDescription { get; set; }
        public string DistrictScale { get; set; }
        public string DistrictLink { get; set; }
        public string DistrictStreamInformation { get; set; }


    }
}
