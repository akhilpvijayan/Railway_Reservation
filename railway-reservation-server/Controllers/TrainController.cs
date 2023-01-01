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
    public class TrainController : ControllerBase
    {
        #region Private Functions
        private readonly ITrainService _trainService;
        #endregion

        #region Constructors
        public TrainController(ITrainService trainService)
        {
            _trainService = trainService;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("Trains/{source}/{destination}/{trainTypeId}")]
        [ProducesResponseType(typeof(Trains), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<Trains> GetTrains(string source, string destination, string trainTypeId)
        {
            return _trainService.GetTrains(source,destination,trainTypeId);
        }
        #endregion
    }
}
