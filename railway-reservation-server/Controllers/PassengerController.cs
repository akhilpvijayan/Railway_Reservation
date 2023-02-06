using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using railwayReservation.Business.Services;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Controllers
{
    [ApiController]
    public class PassengerController : ControllerBase
    {
        #region Private Functions
        private readonly IPassengerService _passengerService;
        #endregion

        #region Constructors
        public PassengerController(
            IPassengerService passengerService)
        {
            _passengerService = passengerService;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("Passengers")]
        [ProducesResponseType(typeof(Passengers), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<Passengers> GetAllPassengers()
        {
            return _passengerService.GetAllPassengers();
        }

        [HttpGet]
        [Route("Passengers/{passengerId}")]
        [ProducesResponseType(typeof(Passengers), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<Passengers> GetPassenger(int passengerId)
        {
            return _passengerService.GetPassenger(passengerId);
        }

        [HttpPost]
        [Route("Passengers")]
        [ProducesResponseType(typeof(Passengers), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<Passengers> AddPassenger(Passengers passengers)
        {
            return _passengerService.AddPassenger(passengers);
        }

        [HttpPut]
        [Route("Passengers")]
        public IEnumerable<Passengers> UpdatePassenger(Passengers passengers)
        {
            return _passengerService.UpdatePassenger(passengers);
        }

        [HttpDelete]
        [Route("Passengers/{passengerId}")]
        public Task<Passengers> DeletePassenger(int passengerId)
        {
            return _passengerService.DeletePassenger(passengerId);
        }
        #endregion
    }
}
