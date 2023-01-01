using Microsoft.EntityFrameworkCore;
using railwayReservation.Business.DataServices;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services.DataServices
{
    public class TrainDataService : ITrainDataService
    {
        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion
        #region Constructor
        public TrainDataService(ApplicationDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region Public Functions
        public IEnumerable<Trains> GetTrains(string source, string destination, string trainTypeId)
        {
            return _applicationDbContext.Trains.FromSqlRaw("[spGetTrainonSearch] {0},{1},{2}", source,destination,trainTypeId);
        }
        #endregion

    }
}
