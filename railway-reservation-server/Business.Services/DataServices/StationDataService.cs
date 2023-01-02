using railwayReservation.Business.DataServices;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services.DataServices
{
    public class StationDataService : IStationDataService
    {
        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion
        #region Constructor
        public StationDataService(ApplicationDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region Public Functions
        public IEnumerable<Stations> GetStations()
        {
            return _applicationDbContext.Stations.ToList();
        }
        #endregion
    }
}
