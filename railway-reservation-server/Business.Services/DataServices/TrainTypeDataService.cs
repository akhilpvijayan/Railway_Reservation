using railwayReservation.Business.DataServices;
using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services.DataServices
{
    public class TrainTypeDataService : ITrainTypeDataService
    {
        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion
        #region Constructor
        public TrainTypeDataService(ApplicationDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region Public Functions
        public IEnumerable<TrainTypes> GetTrainTypes()
        {
            return _applicationDbContext.Traintypes.ToList();
        }
        #endregion
    }
}
