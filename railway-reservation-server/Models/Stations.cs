using railwayReservation.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Models
{
    public class Stations :IStations
    {
        [Key]
        public int stationId { get; set; }
        public string stationName { get; set; }
    }
}
