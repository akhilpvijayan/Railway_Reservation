using railwayReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Services
{
    public interface ITrainTypeService
    {
        IEnumerable<TrainTypes> GetTrainTypes();
    }
}
