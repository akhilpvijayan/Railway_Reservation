using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Models
{
    public interface ITrains
    {
        int trainId { get; set; }
        string trainName { get; set; }
        string source { get; set; }
        string destination { get; set; }
        int generalSeats { get; set; }
        int ACSeats { get; set; }
        int semiSleeperSeats { get; set; }
        int sleeperSeats { get; set; }
    }
}
