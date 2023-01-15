using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using railwayReservation.Business.Services;

namespace railwayReservation.Controllers
{
    [ApiController]
    public class StationController : ControllerBase
    {
        #region Private Functions
        private readonly IStationService _stationService;
        #endregion

        #region Constructors
        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("Stations")]
        [ProducesResponseType(typeof(Stations), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<Stations> GetStations()
        {
            return _stationService.GetStations();
        }
        [HttpGet]
        [Route("Stations/{stationId}")]
        [ProducesResponseType(typeof(Stations), 200)]
        [ProducesResponseType(404)]
        public ActionResult<Stations> GetStation(int stationId)
        {
            return _stationService.GetStation(stationId);
        }
        #endregion
    }
}
