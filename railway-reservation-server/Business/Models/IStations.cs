using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Models
{
    public interface IStations
    {
        int stationId { get; set; }
        string stationName { get; set; }
        int trainId { get; set; }
        DateTime arrivalTime { get; set; }
        DateTime depatureTime { get; set; }
    }
}
