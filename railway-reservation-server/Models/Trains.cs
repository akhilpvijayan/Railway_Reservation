using railwayReservation.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Models
{
    public class Trains:ITrains
    {
        [Key]
        public int trainId { get; set; }
        public string trainName { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public int generalSeats { get; set; }
        public int ACSeats { get; set; }
        public int semiSleeperSeats { get; set; }
        public int sleeperSeats { get; set; }
    }
}
