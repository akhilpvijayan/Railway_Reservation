using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace railwayReservation.Business.Models
{
    public interface ITrainTypes
    {
        int trainTypeId { get; set; }
        string trainType { get; set; }
    }
}
