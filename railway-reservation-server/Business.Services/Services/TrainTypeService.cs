using railwayReservation.Business.DataServices;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services.Services
{
    public class TrainTypeService : ITrainTypeService
    {
        #region Private Functions
        private readonly ITrainTypeDataService _trainTypeDataService;
        #endregion
        #region Constructor
        public TrainTypeService(ITrainTypeDataService trainTypeDataService)
        {
            _trainTypeDataService = trainTypeDataService;
        }
        #endregion
        #region Public Functions
        public IEnumerable<TrainTypes> GetTrainTypes()
        {
            return _trainTypeDataService.GetTrainTypes();
        }
        #endregion
    }
}
