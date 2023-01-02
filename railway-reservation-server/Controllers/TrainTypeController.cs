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
    public class TrainTypeController : ControllerBase
    {
        #region Private Functions
        private readonly ITrainTypeService _trainTypeService;
        #endregion

        #region Constructors
        public TrainTypeController(ITrainTypeService trainTypeService)
        {
            _trainTypeService = trainTypeService;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("TrainTypes")]
        [ProducesResponseType(typeof(TrainTypes), 200)]
        [ProducesResponseType(404)]
        public IEnumerable<TrainTypes> GetTrainTypes()
        {
            return _trainTypeService.GetTrainTypes();
        }
        #endregion
    }
}
