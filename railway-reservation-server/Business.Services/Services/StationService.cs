using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using railwayReservation.Business.DataServices;
using railwayReservation.Business.Services;
using railwayReservation.Models;

namespace railwayReservation.Business.Services.Services
{
    public class StationService : IStationService
    {
        #region Private Functions
        private readonly IStationDataService _stationDataService;
        #endregion
        #region Constructor
        public StationService(IStationDataService stationDataService)
        {
            _stationDataService = stationDataService;
        }
        #endregion
        #region Public Functions
        public IEnumerable<Stations> GetStations()
        {
            return _stationDataService.GetStations();
        }
        #endregion
    }
}
