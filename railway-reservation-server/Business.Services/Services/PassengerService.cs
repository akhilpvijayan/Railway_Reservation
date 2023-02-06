using Microsoft.AspNetCore.Mvc;
using railwayReservation.Business.DataServices;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services
{
    public class PassengerService : IPassengerService
    {
        #region Private Functions
        private readonly IPassengerDataService _passengerDataService;
        #endregion
        #region Constructor
        public PassengerService(IPassengerDataService passengerDataService)
        {
            _passengerDataService = passengerDataService;
        }
        #endregion
        #region Public Functions
        public IEnumerable<Passengers> GetAllPassengers()
        {
            return _passengerDataService.GetAllPassengers();
        }

        public IEnumerable<Passengers> GetPassenger(int passengerId)
        {
            return _passengerDataService.GetPassenger(passengerId);
        }

        public IEnumerable<Passengers> AddPassenger(Passengers passengers)
        {
            return _passengerDataService.AddPassenger(passengers);
        }
        public IEnumerable<Passengers> UpdatePassenger(Passengers passengers)
        {
            return _passengerDataService.UpdatePassenger(passengers);
        }
        public Task<Passengers> DeletePassenger(int passengerId)
        {
            return _passengerDataService.DeletePassenger(passengerId);
        }
        #endregion
    }
}
