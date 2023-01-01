using railwayReservation.Business.DataServices;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services.Services
{
    public class TrainService : ITrainService
    {
        #region Private Functions
        private readonly ITrainDataService _trainDataService;
        #endregion
        #region Constructor
        public TrainService(ITrainDataService trainDataService)
        {
            _trainDataService = trainDataService;
        }
        #endregion
        #region Public Functions
        public IEnumerable<Trains> GetTrains(string source, string destination, string trainTypeId)
        {
            return _trainDataService.GetTrains(source,destination,trainTypeId);
        }
        #endregion
    }
}
