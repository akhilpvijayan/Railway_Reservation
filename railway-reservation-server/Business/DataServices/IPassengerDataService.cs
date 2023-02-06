using Microsoft.AspNetCore.Mvc;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.DataServices
{
    public interface IPassengerDataService
    {
        IEnumerable<Passengers> GetAllPassengers();
        IEnumerable<Passengers> AddPassenger(Passengers passengers);
        IEnumerable<Passengers> GetPassenger(int passengerId);
        IEnumerable<Passengers> UpdatePassenger( Passengers passengers);
        Task<Passengers> DeletePassenger(int passengerId);
    }
}
